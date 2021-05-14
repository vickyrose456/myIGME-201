
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
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.friendsPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(225)))), ((int)(((byte)(205)))));
            this.messagesRichTextBox.Location = new System.Drawing.Point(187, 108);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.Size = new System.Drawing.Size(594, 174);
            this.messagesRichTextBox.TabIndex = 16;
            this.messagesRichTextBox.Text = "";
            // 
            // userMsgRichTextBox
            // 
            this.userMsgRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(225)))), ((int)(((byte)(205)))));
            this.userMsgRichTextBox.Location = new System.Drawing.Point(187, 328);
            this.userMsgRichTextBox.Name = "userMsgRichTextBox";
            this.userMsgRichTextBox.Size = new System.Drawing.Size(594, 90);
            this.userMsgRichTextBox.TabIndex = 15;
            this.userMsgRichTextBox.Text = "";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.BackColor = System.Drawing.Color.White;
            this.searchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.Image")));
            this.searchPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchPictureBox.InitialImage")));
            this.searchPictureBox.Location = new System.Drawing.Point(630, 6);
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
            this.friendsPictureBox.Location = new System.Drawing.Point(694, 7);
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
            this.homePictureBox.Location = new System.Drawing.Point(753, 6);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(41, 38);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePictureBox.TabIndex = 11;
            this.homePictureBox.TabStop = false;
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(717, 394);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(64, 24);
            this.sendMsgButton.TabIndex = 17;
            this.sendMsgButton.Text = "Send";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(105)))), ((int)(((byte)(3)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 443);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 46);
            this.panel2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.userMsgRichTextBox);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.friendsPictureBox);
            this.Controls.Add(this.homePictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.PictureBox friendsPictureBox;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

