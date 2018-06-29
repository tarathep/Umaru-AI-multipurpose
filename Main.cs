using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Matrix;
using Matrix.Xml;
using Matrix.Xmpp;
using Matrix.Xmpp.Client;
using Umaru_AI.Settings;
using RosterItem = Matrix.Xmpp.Roster.RosterItem;
using Subscription = Matrix.Xmpp.Roster.Subscription;
using System.IO;


namespace Umaru_AI
{
    public partial class Main : Form
    {
        int move, mx, my;//form move varaible
        
        //WinAPI-Declaration for SendMessage
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr window, int message, int wparam, int lparam);

        const int WM_VSCROLL = 0x115;
        const int SB_BOTTOM = 7;

        private readonly Dictionary<string, ListViewGroup> _dictContactGroups = new Dictionary<string, ListViewGroup>();
        private readonly Dictionary<Jid, RosterItem> _dictContats = new Dictionary<Jid, RosterItem>();

        private Settings.Settings _settings;
        private Login _login;

        
        public Main()
        {
            InitializeComponent();
            SetLicense();

            RegisterCustomElements();
            InitSettings();
            InitContactList();
        }
//---------------------------------<FormMove>---------------------------------------------
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if(move ==1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mx = e.X;
            my = e.Y;
        }
//------------------------------------<end>-----------------------------------------------

//----------------------------------<Hangout>---------------------------------------------
        private void listContacts_MouseUp(object sender, MouseEventArgs e)
        {
            //Check if right clicked on a ListView Item
            if ((listContacts.SelectedItems.Count != 0) && (e.Button == MouseButtons.Right))
            {
                // dynamically adjust context menu with resources.

                var item = listContacts.SelectedItems[0] as RosterListViewItem;
                foreach (string res in item.Resources)
                {
                    Jid jid = item.Name + "/" + res;
                    var menu = new ToolStripMenuItem(res);

                }
                // show context menu
                ctxMenuRoster.Show(Cursor.Position);
            }
        }

        private void xmppClient_OnRosterEnd(object sender, Matrix.EventArgs e)
        {
            DisplayEvent("OnRosterEnd");
        }

        private void xmppClient_OnRosterItem(object sender, Matrix.Xmpp.Roster.RosterEventArgs e)
        {
            DisplayEvent(string.Format("OnRosterItem\t{0}\t{1}", e.RosterItem.Jid, e.RosterItem.Name));

            if (e.RosterItem.Subscription != Subscription.remove)
            {
                // set a default group name
                string groupname = "Contacts";

                // id the contact has groups get the 1st group. In this example we don't support multiple or nested groups
                // for contacts, but XMPP has support for this.
                if (e.RosterItem.HasGroups)
                    groupname = e.RosterItem.GetGroups()[0];

                if (!_dictContactGroups.ContainsKey(groupname))
                {
                    var newGroup = new ListViewGroup(groupname);
                    _dictContactGroups.Add(groupname, newGroup);
                    listContacts.Groups.Add(newGroup);
                }

                var listGroup = _dictContactGroups[groupname];

                // contact already exists, this is a contact update
                if (_dictContats.ContainsKey(e.RosterItem.Jid))
                {
                    listContacts.Items.RemoveByKey(e.RosterItem.Jid);
                }

                var newItem = new RosterListViewItem(e.RosterItem.Name ?? e.RosterItem.Jid, 0, listGroup)
                { Name = e.RosterItem.Jid.Bare };
                newItem.SubItems.AddRange(new[] { "", "" });


                listContacts.Items.Add(newItem);
            }
        }

        private void xmppClient_OnReceiveXml(object sender, TextEventArgs e)
        {
            rtfDebug.SelectionStart = rtfDebug.Text.Length;
            rtfDebug.SelectionLength = 0;
            rtfDebug.SelectionColor = Color.Red;
            rtfDebug.AppendText("RECV: ");
            rtfDebug.SelectionColor = Color.Black;
            rtfDebug.AppendText(e.Text);
            rtfDebug.AppendText("\r\n");
            ScrollRtfToEnd(rtfDebug);
        }

        private void xmppClient_OnSendXml(object sender, TextEventArgs e)
        {
            rtfDebug.SelectionStart = rtfDebug.Text.Length;
            rtfDebug.SelectionLength = 0;
            rtfDebug.SelectionColor = Color.Blue;
            rtfDebug.AppendText("SEND: ");
            rtfDebug.SelectionColor = Color.Black;
            rtfDebug.AppendText(e.Text);
            rtfDebug.AppendText("\r\n");
            ScrollRtfToEnd(rtfDebug);
        }

        private void xmppClient_OnAuthError(object sender, Matrix.Xmpp.Sasl.SaslEventArgs e)
        {
            DisplayEvent("OnAuthError");
            xmppClient.Close();
        }

        private void xmppClient_OnError(object sender, ExceptionEventArgs e)
        {
            DisplayEvent("OnError");
        }

        private void xmppClient_OnStreamError(object sender, StreamErrorEventArgs e)
        {
            DisplayEvent("OnStreamError");
        }

        private void xmppClient_OnBind(object sender, JidEventArgs e)
        {
            DisplayEvent("OnBind");
        }

        private void xmppClient_OnClose(object sender, Matrix.EventArgs e)
        {
            DisplayEvent("OnClose");
            listContacts.Items.Clear();
        }

        private void xmppClient_OnLogin(object sender, Matrix.EventArgs e)
        {
            DisplayEvent("OnLogin");
        }

        private void xmppClient_OnMessage(object sender, MessageEventArgs e)
        {
            DisplayEvent("OnMessage");

            if (e.Message.Type == MessageType.error)
            {
                return;
            }
            if (e.Message.Body != null)
            {
                if (!Util.ChatForms.ContainsKey(e.Message.From.Bare))
                {
                    //get nickname from the roster listview
                    string nick = e.Message.From.Bare;
                    var item = listContacts.Items[e.Message.From.Bare];
                    if (item != null)
                        nick = item.Text;
                    //-------------------------------------------------------------------------- 
                    var f = new HangoutChat(e.Message.From, xmppClient, nick);
                    f.Show(); //fom chat show
                    f.IncomingMessage(e.Message);// message in                      
                    //--------------------------------------------------------------------------
                }
            }
        }

        private string domainemail()// หา email domain
        {
            string[] email;
            email = txtUsername.Text.Split('@');
            return email[0];
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            
            xmppClient.SetUsername(domainemail());
            xmppClient.SetXmppDomain("gmail.com");
            xmppClient.Password = txtPassword.Text;

            xmppClient.Status = "ready for chat";
            xmppClient.Show = Matrix.Xmpp.Show.chat;


            // set settings
            _login.User = domainemail();
            _login.Server = "gmail.com";
            _login.Password = txtPassword.Text;

            xmppClient.Open();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            xmppClient.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Util.SaveSettings(_settings);
        }

        private void chatToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (listContacts.SelectedItems.Count > 0)
            {
                var item = listContacts.SelectedItems[0];
                if (!Util.ChatForms.ContainsKey(item.Name))
                {
                     var f = new HangoutChat(item.Name, xmppClient, item.Text);
                    f.Show();
                }
            }
        }

        private void xmppClient_OnPresence(object sender, PresenceEventArgs e)
        {
            DisplayEvent(string.Format("OnPresence\t{0}", e.Presence.From));

            if (e.Presence.Type != PresenceType.subscribe || e.Presence.Type != PresenceType.subscribed || e.Presence.Type != PresenceType.unsubscribe ||
                e.Presence.Type != PresenceType.unsubscribe || e.Presence.Type != PresenceType.unsubscribed)
            {
                var item = listContacts.Items[e.Presence.From.Bare] as RosterListViewItem;
                if (item != null)
                {
                    item.ImageIndex = Util.GetRosterImageIndex(e.Presence);
                    string resource = e.Presence.From.Resource;
                    if (e.Presence.Type != PresenceType.unavailable)
                    {
                        if (!item.Resources.Contains(resource))
                            item.Resources.Add(resource);
                    }
                    else
                    {
                        if (item.Resources.Contains(resource))
                            item.Resources.Remove(resource);
                    }
                }
            }
        }
 
        private static void RegisterCustomElements() //reg
        {
            Factory.RegisterElement<Settings.Settings>("ag-software:settings", "Settings");
            Factory.RegisterElement<Login>("ag-software:settings", "Login");
        }

        private void InitSettings() //setting File save data
        {
            _settings = Util.LoadSettings();
            if (_settings.Login == null)
                _settings.Login = new Login();

            _login = _settings.Login;

            if (_login != null)
            {
                if (!string.IsNullOrEmpty(_login.User))

                    txtUsername.Text = _login.User;

                if (!string.IsNullOrEmpty(_login.Server))
                    txtUsername.Text  = _login.Server;

                if (!string.IsNullOrEmpty(_login.Password))
                    txtPassword.Text = _login.Password;
            }
        }

        private static void SetLicense() //license XMPP MATRIX
        {
            // request demo license here:
            // http://www.ag-software.net/matrix-xmpp-sdk/request-demo-license/
            const string LIC = @"eJxkkFtTwjAQhf+K46ujoaJcnDWjDUXQolBUhLeUpiXYNDWXFvj1oty8vOzs
7rdn98yCz6cs0+xoIdJMXx/T5FTL2JRUsat0g44x9JWM7NR0Izw0NuIS0KED
A0szw80SO4D2ORCrjRRMYXikgmGvoKmlRipA3zUQKXKaLXeAy+xoawXQjoEn
KE+xpinTNz+cnUXroQ1bD+8PveQRNcxb5Fyx1jrD5xWnVmk6VUD/EHR1iwmJ
jbLrXdsCvuJv/aVT+dL/ATDkSUaNVQzbjl6VuRP1X/vtMeGoES/Hes7avY8H
gaZE9dnl4N0JTwztBKuQiNnCLKukSJLBSU6c+uQ2JkS79eYYpYYGppIHb2/q
2QuLc78xHs09139yJwx5sxWaN4Jk5N4+XaC85Pe+lnmtbNNQsJek4Q/Lak+i
WX0StGum+KA2jNMAlUFxN1AjN+5Nmu/XgA6+AW3fjT8FEA==";
            Matrix.License.LicenseManager.SetLicense(LIC);

            // when something is wrong with your license you can find the error here
            Console.WriteLine(Matrix.License.LicenseManager.LicenseError);
        }

        private void DisplayEvent(string ev)
        {
            listEvents.Items.Add(ev);
            listEvents.SelectedIndex = listEvents.Items.Count - 1;
        }
   
        private void ScrollRtfToEnd(RichTextBox rtf) // read end
        {
            SendMessage(rtf.Handle, WM_VSCROLL, SB_BOTTOM, 0);
        }

        private void InitContactList() //contact list show
        {
            listContacts.Clear();

            listContacts.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listContacts.Columns.Add("Status", 75, HorizontalAlignment.Left);
            listContacts.Columns.Add("Resource", 75, HorizontalAlignment.Left);

            listContacts.LargeImageList = ilstStatus;
        }


        private void button4_Click(object sender, System.EventArgs e)
        {
            rtfDebug.Show();
            listEvents.Show();
            on.Hide();
            off.Show();
            panel1.BackColor = Color.GreenYellow;
            
        }

        private void button5_Click(object sender,System.EventArgs e)
        {
            setstart();
        }
       private void setstart()
        {
            rtfDebug.Hide();
            listEvents.Hide();
            on.Show();
            off.Hide();
            panel1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            showmsg(textBox1 .Text);
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {

        }

        //----------------------------------<End>-------------------------------------------

        private void Main_Load(object sender, System.EventArgs e)
        {
            setstart();   
            listEvents.Hide();
            rtfDebug.Hide();
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            textBox2.Hide();
            pictureBox3.Hide();
            timer1.Stop();
        }

        private void Minitray_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, System.EventArgs e)
        {
            Close();
            
        }
        
        private void showmsg(string msgtxt)
        {
            pictureBox3.Show();
            textBox2.Show();
            textBox2.Text = msgtxt;
            timer1.Interval = 7000;
            timer1.Start();          
        }
        
       

    }

}
