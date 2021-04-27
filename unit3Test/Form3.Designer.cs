
namespace unit3Test
{
    partial class Form3
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
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.friendsListRadioButton = new System.Windows.Forms.RadioButton();
            this.latestPostRadioButton2 = new System.Windows.Forms.RadioButton();
            this.directMessageRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.optionsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.directMessageRadioButton);
            this.optionsGroupBox.Controls.Add(this.latestPostRadioButton2);
            this.optionsGroupBox.Controls.Add(this.friendsListRadioButton);
            this.optionsGroupBox.Location = new System.Drawing.Point(226, 109);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(455, 338);
            this.optionsGroupBox.TabIndex = 0;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // friendsListRadioButton
            // 
            this.friendsListRadioButton.AutoSize = true;
            this.friendsListRadioButton.Location = new System.Drawing.Point(19, 72);
            this.friendsListRadioButton.Name = "friendsListRadioButton";
            this.friendsListRadioButton.Size = new System.Drawing.Size(199, 36);
            this.friendsListRadioButton.TabIndex = 0;
            this.friendsListRadioButton.TabStop = true;
            this.friendsListRadioButton.Text = "Friends List";
            this.friendsListRadioButton.UseVisualStyleBackColor = true;
            // 
            // latestPostRadioButton2
            // 
            this.latestPostRadioButton2.AutoSize = true;
            this.latestPostRadioButton2.Location = new System.Drawing.Point(19, 244);
            this.latestPostRadioButton2.Name = "latestPostRadioButton2";
            this.latestPostRadioButton2.Size = new System.Drawing.Size(208, 36);
            this.latestPostRadioButton2.TabIndex = 1;
            this.latestPostRadioButton2.TabStop = true;
            this.latestPostRadioButton2.Text = "Latest Posts";
            this.latestPostRadioButton2.UseVisualStyleBackColor = true;
            // 
            // directMessageRadioButton
            // 
            this.directMessageRadioButton.AutoSize = true;
            this.directMessageRadioButton.Location = new System.Drawing.Point(19, 163);
            this.directMessageRadioButton.Name = "directMessageRadioButton";
            this.directMessageRadioButton.Size = new System.Drawing.Size(248, 36);
            this.directMessageRadioButton.TabIndex = 2;
            this.directMessageRadioButton.TabStop = true;
            this.directMessageRadioButton.Text = "Direct Message";
            this.directMessageRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your message";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(687, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1594, 247);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.Visible = false;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 111);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(638, 38);
            this.messageTextBox.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1594, 704);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.optionsGroupBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.RadioButton directMessageRadioButton;
        private System.Windows.Forms.RadioButton latestPostRadioButton2;
        private System.Windows.Forms.RadioButton friendsListRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}