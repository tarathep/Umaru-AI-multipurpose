namespace Umaru_AI
{
    partial class HangoutChat
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
            this.rtfChat = new System.Windows.Forms.RichTextBox();
            this.cmdSand = new System.Windows.Forms.Button();
            this.rtfSand = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfChat
            // 
            this.rtfChat.Location = new System.Drawing.Point(0, 32);
            this.rtfChat.Name = "rtfChat";
            this.rtfChat.Size = new System.Drawing.Size(272, 151);
            this.rtfChat.TabIndex = 0;
            this.rtfChat.Text = "";
            // 
            // cmdSand
            // 
            this.cmdSand.BackColor = System.Drawing.Color.Transparent;
            this.cmdSand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cmdSand.Location = new System.Drawing.Point(223, 189);
            this.cmdSand.Name = "cmdSand";
            this.cmdSand.Size = new System.Drawing.Size(49, 29);
            this.cmdSand.TabIndex = 1;
            this.cmdSand.Text = "ส่ง";
            this.cmdSand.UseVisualStyleBackColor = false;
            this.cmdSand.Click += new System.EventHandler(this.cmdSand_Click);
            // 
            // rtfSand
            // 
            this.rtfSand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfSand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rtfSand.Location = new System.Drawing.Point(0, 189);
            this.rtfSand.Name = "rtfSand";
            this.rtfSand.Size = new System.Drawing.Size(217, 29);
            this.rtfSand.TabIndex = 2;
            this.rtfSand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfSand_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 207);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(239, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HangoutChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfSand);
            this.Controls.Add(this.cmdSand);
            this.Controls.Add(this.rtfChat);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangoutChat";
            this.Text = "HangoutChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HangoutChat_FormClosed_1);
            this.Load += new System.EventHandler(this.HangoutChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfChat;
        private System.Windows.Forms.Button cmdSand;
        private System.Windows.Forms.TextBox rtfSand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}