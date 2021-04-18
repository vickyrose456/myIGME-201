
namespace Dyscord
{
    partial class DyscordForm
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
            this.convGroupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.convRichTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.convGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convGroupBox
            // 
            this.convGroupBox.Controls.Add(this.webBrowser1);
            this.convGroupBox.Controls.Add(this.convRichTextBox);
            this.convGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.convGroupBox.Location = new System.Drawing.Point(0, 0);
            this.convGroupBox.Name = "convGroupBox";
            this.convGroupBox.Size = new System.Drawing.Size(1450, 955);
            this.convGroupBox.TabIndex = 0;
            this.convGroupBox.TabStop = false;
            this.convGroupBox.Text = "Conversation";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(912, 37);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(538, 711);
            this.webBrowser1.TabIndex = 1;
            // 
            // convRichTextBox
            // 
            this.convRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.convRichTextBox.Location = new System.Drawing.Point(3, 34);
            this.convRichTextBox.Name = "convRichTextBox";
            this.convRichTextBox.Size = new System.Drawing.Size(1444, 635);
            this.convRichTextBox.TabIndex = 0;
            this.convRichTextBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 675);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msgRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.usersButton);
            this.splitContainer1.Panel2.Controls.Add(this.sendButton);
            this.splitContainer1.Panel2.Controls.Add(this.userTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.loginButton);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1450, 208);
            this.splitContainer1.SplitterDistance = 915;
            this.splitContainer1.TabIndex = 1;
            // 
            // msgRichTextBox
            // 
            this.msgRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.msgRichTextBox.Name = "msgRichTextBox";
            this.msgRichTextBox.Size = new System.Drawing.Size(915, 208);
            this.msgRichTextBox.TabIndex = 0;
            this.msgRichTextBox.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(362, 119);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 52);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(206, 119);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(127, 52);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(49, 119);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 52);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(49, 33);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(284, 38);
            this.userTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(362, 25);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(127, 52);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // DyscordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 883);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.convGroupBox);
            this.Name = "DyscordForm";
            this.Text = "Dyscord";
            this.convGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox convGroupBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox convRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox msgRichTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button sendButton;
    }
}