
namespace Sherlock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.quickLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.happyPictureBox = new System.Windows.Forms.PictureBox();
            this.sadPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quickLabel
            // 
            this.quickLabel.AutoSize = true;
            this.quickLabel.Location = new System.Drawing.Point(13, 13);
            this.quickLabel.Name = "quickLabel";
            this.quickLabel.Size = new System.Drawing.Size(225, 13);
            this.quickLabel.TabIndex = 0;
            this.quickLabel.Text = "The quick brown fox jumped over the lazy dog";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 30);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(222, 20);
            this.textBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Location = new System.Drawing.Point(385, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "people.rit.edu/dxsigm/sherlock.html";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(397, 308);
            this.webBrowser1.TabIndex = 0;
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.Red;
            this.countdownLabel.Location = new System.Drawing.Point(79, 93);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(86, 31);
            this.countdownLabel.TabIndex = 3;
            this.countdownLabel.Text = "label1";
            // 
            // happyPictureBox
            // 
            this.happyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("happyPictureBox.Image")));
            this.happyPictureBox.Location = new System.Drawing.Point(44, 169);
            this.happyPictureBox.Name = "happyPictureBox";
            this.happyPictureBox.Size = new System.Drawing.Size(162, 168);
            this.happyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.happyPictureBox.TabIndex = 4;
            this.happyPictureBox.TabStop = false;
            // 
            // sadPictureBox
            // 
            this.sadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sadPictureBox.Image")));
            this.sadPictureBox.Location = new System.Drawing.Point(44, 169);
            this.sadPictureBox.Name = "sadPictureBox";
            this.sadPictureBox.Size = new System.Drawing.Size(162, 168);
            this.sadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sadPictureBox.TabIndex = 5;
            this.sadPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(710, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sadPictureBox);
            this.Controls.Add(this.happyPictureBox);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.quickLabel);
            this.Name = "Form1";
            this.Text = "Sherlock";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.happyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quickLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.PictureBox happyPictureBox;
        private System.Windows.Forms.PictureBox sadPictureBox;
        private System.Windows.Forms.Button exitButton;
    }
}

