namespace Umaru_AI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TalkBot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.listContacts = new System.Windows.Forms.ListView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.off = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.on = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.IcoTab = new System.Windows.Forms.ImageList(this.components);
            this.rtfDebug = new System.Windows.Forms.RichTextBox();
            this.listEvents = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minitray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xmppClient = new Matrix.Xmpp.Client.XmppClient();
            this.mucManager = new Matrix.Xmpp.Client.MucManager();
            this.ctxMenuRoster = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilstStatus = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ctxMenuRoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.ImageList = this.IcoTab;
            this.tabControl1.Location = new System.Drawing.Point(1, 209);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(426, 265);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageKey = "m[1].png";
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "คุยกับบอท";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TalkBot);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(11, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สนทนา";
            // 
            // TalkBot
            // 
            this.TalkBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TalkBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TalkBot.Location = new System.Drawing.Point(300, 39);
            this.TalkBot.Name = "TalkBot";
            this.TalkBot.Size = new System.Drawing.Size(95, 47);
            this.TalkBot.TabIndex = 0;
            this.TalkBot.Text = "ส่ง";
            this.TalkBot.UseVisualStyleBackColor = true;
            this.TalkBot.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(6, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 47);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.ImageKey = "Calculator-icon.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "เครื่องคิดเลข";
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "Translate_icon_homepage.svg.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 74);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(418, 187);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "แปลภาษา";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.ImageKey = "Sticky_Notes.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 74);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(418, 187);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "บันทึก";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.txtPassword);
            this.tabPage5.Controls.Add(this.txtUsername);
            this.tabPage5.Controls.Add(this.listContacts);
            this.tabPage5.ImageKey = "hangouts-150x150.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 74);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(418, 187);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "คุยแฮงเอ้า";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(334, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "ล็อกเอ้า";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(251, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "ล็อกอิน";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(271, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'o';
            this.txtPassword.Size = new System.Drawing.Size(124, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(271, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // listContacts
            // 
            this.listContacts.Location = new System.Drawing.Point(7, 0);
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(207, 183);
            this.listContacts.TabIndex = 0;
            this.listContacts.UseCompatibleStateImageBehavior = false;
            this.listContacts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listContacts_MouseUp);
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "36-remote-control-streamline.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 74);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(418, 187);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "ควบคุมบอท";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.panel1);
            this.tabPage7.ImageKey = "settings-icon.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 74);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(418, 187);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "ตั้งค่า";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "แสดงการทำงานแฮงเอ้า";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.off);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.on);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(310, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 27);
            this.panel1.TabIndex = 0;
            // 
            // off
            // 
            this.off.BackColor = System.Drawing.Color.White;
            this.off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.off.Location = new System.Drawing.Point(44, 5);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(28, 16);
            this.off.TabIndex = 2;
            this.off.UseVisualStyleBackColor = false;
            this.off.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ปิด";
            // 
            // on
            // 
            this.on.BackColor = System.Drawing.Color.White;
            this.on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.on.Location = new System.Drawing.Point(3, 5);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(28, 16);
            this.on.TabIndex = 1;
            this.on.UseVisualStyleBackColor = false;
            this.on.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "เปิด";
            // 
            // tabPage8
            // 
            this.tabPage8.ImageKey = "orange-about-256.png";
            this.tabPage8.Location = new System.Drawing.Point(4, 74);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(418, 187);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "เกี่ยวกับ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // IcoTab
            // 
            this.IcoTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IcoTab.ImageStream")));
            this.IcoTab.TransparentColor = System.Drawing.Color.Transparent;
            this.IcoTab.Images.SetKeyName(0, "36-remote-control-streamline.png");
            this.IcoTab.Images.SetKeyName(1, "Calculator-icon.png");
            this.IcoTab.Images.SetKeyName(2, "hangouts-150x150.png");
            this.IcoTab.Images.SetKeyName(3, "m[1].png");
            this.IcoTab.Images.SetKeyName(4, "Sticky_Notes.png");
            this.IcoTab.Images.SetKeyName(5, "Translate_icon_homepage.svg.png");
            this.IcoTab.Images.SetKeyName(6, "settings-icon.png");
            this.IcoTab.Images.SetKeyName(7, "orange-about-256.png");
            // 
            // rtfDebug
            // 
            this.rtfDebug.BackColor = System.Drawing.Color.Gainsboro;
            this.rtfDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfDebug.Location = new System.Drawing.Point(439, 325);
            this.rtfDebug.Name = "rtfDebug";
            this.rtfDebug.Size = new System.Drawing.Size(182, 145);
            this.rtfDebug.TabIndex = 5;
            this.rtfDebug.Text = "";
            // 
            // listEvents
            // 
            this.listEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.listEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEvents.FormattingEnabled = true;
            this.listEvents.Location = new System.Drawing.Point(439, 180);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(182, 130);
            this.listEvents.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 177);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkOrange;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.ImageList = this.IcoTab;
            this.Exit.Location = new System.Drawing.Point(395, 179);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 28);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(433, 214);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // Minitray
            // 
            this.Minitray.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Minitray.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Minitray.FlatAppearance.BorderSize = 2;
            this.Minitray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minitray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Minitray.Location = new System.Drawing.Point(361, 179);
            this.Minitray.Name = "Minitray";
            this.Minitray.Size = new System.Drawing.Size(28, 28);
            this.Minitray.TabIndex = 4;
            this.Minitray.Text = "-";
            this.Minitray.UseVisualStyleBackColor = false;
            this.Minitray.Click += new System.EventHandler(this.Minitray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UMARU AI";
            // 
            // xmppClient
            // 
            this.xmppClient.Compression = false;
            this.xmppClient.Dispatcher = null;
            this.xmppClient.Hostname = null;
            this.xmppClient.ProxyHostname = null;
            this.xmppClient.ProxyPass = null;
            this.xmppClient.ProxyPort = 1080;
            this.xmppClient.ProxyType = Matrix.Net.Proxy.ProxyType.None;
            this.xmppClient.ProxyUser = null;
            this.xmppClient.ResolveSrvRecords = true;
            this.xmppClient.Status = "";
            this.xmppClient.StreamManagement = false;
            this.xmppClient.Transport = Matrix.Net.Transport.Socket;
            this.xmppClient.Uri = null;
            this.xmppClient.OnRosterEnd += new System.EventHandler<Matrix.EventArgs>(this.xmppClient_OnRosterEnd);
            this.xmppClient.OnRosterItem += new System.EventHandler<Matrix.Xmpp.Roster.RosterEventArgs>(this.xmppClient_OnRosterItem);
            this.xmppClient.OnPresence += new System.EventHandler<Matrix.Xmpp.Client.PresenceEventArgs>(this.xmppClient_OnPresence);
            this.xmppClient.OnMessage += new System.EventHandler<Matrix.Xmpp.Client.MessageEventArgs>(this.xmppClient_OnMessage);
            this.xmppClient.OnBind += new System.EventHandler<Matrix.JidEventArgs>(this.xmppClient_OnBind);
            this.xmppClient.OnReceiveXml += new System.EventHandler<Matrix.TextEventArgs>(this.xmppClient_OnReceiveXml);
            this.xmppClient.OnSendXml += new System.EventHandler<Matrix.TextEventArgs>(this.xmppClient_OnSendXml);
            this.xmppClient.OnStreamError += new System.EventHandler<Matrix.StreamErrorEventArgs>(this.xmppClient_OnStreamError);
            this.xmppClient.OnError += new System.EventHandler<Matrix.ExceptionEventArgs>(this.xmppClient_OnError);
            this.xmppClient.OnLogin += new System.EventHandler<Matrix.EventArgs>(this.xmppClient_OnLogin);
            this.xmppClient.OnAuthError += new System.EventHandler<Matrix.Xmpp.Sasl.SaslEventArgs>(this.xmppClient_OnAuthError);
            this.xmppClient.OnClose += new System.EventHandler<Matrix.EventArgs>(this.xmppClient_OnClose);
            // 
            // mucManager
            // 
            this.mucManager.XmppClient = this.xmppClient;
            // 
            // ctxMenuRoster
            // 
            this.ctxMenuRoster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatToolStripMenuItem});
            this.ctxMenuRoster.Name = "ctxMenuRoster";
            this.ctxMenuRoster.Size = new System.Drawing.Size(98, 26);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.chatToolStripMenuItem.Text = "chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // ilstStatus
            // 
            this.ilstStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstStatus.ImageStream")));
            this.ilstStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstStatus.Images.SetKeyName(0, "status_grey.png");
            this.ilstStatus.Images.SetKeyName(1, "status_green.png");
            this.ilstStatus.Images.SetKeyName(2, "status_yellow.png");
            this.ilstStatus.Images.SetKeyName(3, "status_red.png");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Umaru_AI.Properties.Resources.msgout;
            this.pictureBox3.Location = new System.Drawing.Point(149, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(293, 107);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox4.Location = new System.Drawing.Point(0, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 270);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox6.Location = new System.Drawing.Point(0, 466);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(433, 10);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox5.Location = new System.Drawing.Point(423, 202);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 272);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(178, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(249, 52);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pass";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(673, 478);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Minitray);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listEvents);
            this.Controls.Add(this.rtfDebug);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ctxMenuRoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList IcoTab;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TalkBot;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Minitray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListView listContacts;
        private System.Windows.Forms.RichTextBox rtfDebug;
        private System.Windows.Forms.ListBox listEvents;
        private Matrix.Xmpp.Client.XmppClient xmppClient;
        private Matrix.Xmpp.Client.MucManager mucManager;
        private System.Windows.Forms.ContextMenuStrip ctxMenuRoster;
        private System.Windows.Forms.ImageList ilstStatus;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Button on;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

