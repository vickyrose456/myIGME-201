
namespace GroupProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userMsgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.Location = new System.Drawing.Point(187, 108);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.Size = new System.Drawing.Size(594, 174);
            this.messagesRichTextBox.TabIndex = 16;
            this.messagesRichTextBox.Text = "";
            // 
            // userMsgRichTextBox
            // 
            this.userMsgRichTextBox.Location = new System.Drawing.Point(133, 328);
            this.userMsgRichTextBox.Name = "userMsgRichTextBox";
            this.userMsgRichTextBox.Size = new System.Drawing.Size(594, 90);
            this.userMsgRichTextBox.TabIndex = 15;
            this.userMsgRichTextBox.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 100);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(106, 173);
            this.webBrowser1.TabIndex = 14;
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.BackColor = System.Drawing.Color.White;
            this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
            this.searchPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.InitialImage")));
            this.searchPictureBox.Location = new System.Drawing.Point(622, 32);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(41, 38);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPictureBox.TabIndex = 13;
            this.searchPictureBox.TabStop = false;
            // 
            // friendsPictureBox
            // 
            this.friendsPictureBox.BackColor = System.Drawing.Color.White;
            this.friendsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("friendsPictureBox.Image")));
            this.friendsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("friendsPictureBox.InitialImage")));
            this.friendsPictureBox.Location = new System.Drawing.Point(686, 33);
            this.friendsPictureBox.Name = "friendsPictureBox";
            this.friendsPictureBox.Size = new System.Drawing.Size(41, 38);
            this.friendsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendsPictureBox.TabIndex = 12;
            this.friendsPictureBox.TabStop = false;
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.White;
            this.homePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homePictureBox.Image")));
            this.homePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("homePictureBox.InitialImage")));
            this.homePictureBox.Location = new System.Drawing.Point(745, 32);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(41, 38);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePictureBox.TabIndex = 11;
            this.homePictureBox.TabStop = false;
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(552, 366);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(175, 52);
            this.sendMsgButton.TabIndex = 17;
            this.sendMsgButton.Text = "Send";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.userMsgRichTextBox);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.friendsPictureBox);
            this.Controls.Add(this.homePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messagesRichTextBox;
        private System.Windows.Forms.RichTextBox userMsgRichTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.PictureBox friendsPictureBox;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.Button sendMsgButton;
    }
}

