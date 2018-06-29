using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix;
using Matrix.Xmpp;
using Matrix.Xmpp.Client;
using EventArgs = System.EventArgs;
using Message = Matrix.Xmpp.Client.Message;
namespace Umaru_AI
{
    public partial class HangoutChat : Form
    {
        int move;
        int mx;
        int my;
        private XmppClient _xmppClient;
        private Jid _jid;
        private readonly string _nickname;
       

        public HangoutChat()
        {
            InitializeComponent();
        }

        public HangoutChat(Jid jid, XmppClient con, string nickname)
        {
            _jid = jid;
            _xmppClient = con;
            _nickname = nickname;
            
            InitializeComponent();
            Text = "Chat with " + nickname;           
            Util.ChatForms.Add(_jid.Bare.ToLower(), this);

            // Setup new Message Callback
            con.MessageFilter.Add(jid, new BareJidComparer(), OnMessage);
        }

        private void OutgoingMessage(Message msg) //Show in rich box sand out
        {
            rtfChat.SelectionColor = Color.Blue;
            rtfChat.AppendText("ฉันพูดว่า : ");
            rtfChat.SelectionColor = Color.Black;
            rtfChat.AppendText(msg.Body);
            rtfChat.AppendText("\r\n");
        }
        //---------------------------------------------------------------------------------
        public void IncomingMessage(Message msg) //input msg Chat to hangout
        {
            try
            {
                rtfChat.SelectionColor = Color.Red;
                rtfChat.AppendText(_nickname + " พูดว่า: ");
                rtfChat.SelectionColor = Color.Black;
                rtfChat.AppendText(msg.Body);
                rtfChat.AppendText("\r\n");
            }
            catch (Exception) { };
           /* if (checkBox1.Checked)
            {
                string tmp = BotHangoutTalk.talkRW(msg.Body);
                var msgx = new Message { Type = MessageType.chat, To = _jid, Body = tmp };
                _xmppClient.Send(msgx); //sand msg to hangout
                OutgoingMessage(msgx); //sand msg to hangout
            }*/
        }

      

        private void OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Body != null)
                IncomingMessage(e.Message);
        }

        private void HangoutChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Util.ChatForms.Remove(_jid.Bare.ToLower());
            _xmppClient.MessageFilter.Remove(_jid);
            _xmppClient = null;
        }

        private void cmdSand_Click(object sender, EventArgs e)
        {
            if (rtfSand .Text  == "")
            {
                rtfSand.Focus();
            }
            else
            {
                var msg = new Message { Type = MessageType.chat, To = _jid, Body = rtfSand . Text };

                _xmppClient.Send(msg); //sand msg to hangout
                OutgoingMessage(msg); //sand msg to hangout
                rtfSand.Text = "";
            }
        }

        private void HangoutChat_Load(object sender, EventArgs e)
        {
            label1.Text = _nickname;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mx = e.X;
            my = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HangoutChat_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Util.ChatForms.Remove(_jid.Bare.ToLower());
            _xmppClient.MessageFilter.Remove(_jid);
            _xmppClient = null;
        }

        private void rtfSand_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (rtfSand.Text == "")
                {
                    rtfSand.Focus();
                }
                else
                {
                    var msg = new Message { Type = MessageType.chat, To = _jid, Body = rtfSand.Text };

                    _xmppClient.Send(msg); //sand msg to hangout
                    OutgoingMessage(msg); //sand msg to hangout
                    rtfSand.Text = "";
                }
            }
        }
    }
}
