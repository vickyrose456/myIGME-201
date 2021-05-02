
namespace Group_Project
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userMsgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.searchPictureBox);
            this.panel1.Controls.Add(this.friendsPictureBox);
            this.panel1.Controls.Add(this.homePictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 40);
            this.panel1.TabIndex = 0;
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.BackColor = System.Drawing.Color.White;
            this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
            this.searchPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.InitialImage")));
            this.searchPictureBox.Location = new System.Drawing.Point(1024, 2);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(41, 38);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPictureBox.TabIndex = 3;
            this.searchPictureBox.TabStop = false;
            // 
            // friendsPictureBox
            // 
            this.friendsPictureBox.BackColor = System.Drawing.Color.White;
            this.friendsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("friendsPictureBox.Image")));
            this.friendsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("friendsPictureBox.InitialImage")));
            this.friendsPictureBox.Location = new System.Drawing.Point(1088, 3);
            this.friendsPictureBox.Name = "friendsPictureBox";
            this.friendsPictureBox.Size = new System.Drawing.Size(41, 38);
            this.friendsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendsPictureBox.TabIndex = 3;
            this.friendsPictureBox.TabStop = false;
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.White;
            this.homePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homePictureBox.Image")));
            this.homePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("homePictureBox.InitialImage")));
            this.homePictureBox.Location = new System.Drawing.Point(1147, 2);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(41, 38);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePictureBox.TabIndex = 2;
            this.homePictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(2)))));
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 573);
            this.panel2.TabIndex = 1;
            // 
            // userMsgRichTextBox
            // 
            this.userMsgRichTextBox.Location = new System.Drawing.Point(173, 438);
            this.userMsgRichTextBox.Name = "userMsgRichTextBox";
            this.userMsgRichTextBox.Size = new System.Drawing.Size(975, 127);
            this.userMsgRichTextBox.TabIndex = 2;
            this.userMsgRichTextBox.Text = "";
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(972, 512);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(175, 52);
            this.sendMsgButton.TabIndex = 3;
            this.sendMsgButton.Text = "Send";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.Location = new System.Drawing.Point(173, 57);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.Size = new System.Drawing.Size(975, 347);
            this.messagesRichTextBox.TabIndex = 4;
            this.messagesRichTextBox.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(150, 346);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1191, 613);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.userMsgRichTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form";
            this.Text = "Private Messages";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.PictureBox friendsPictureBox;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox userMsgRichTextBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.RichTextBox messagesRichTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

