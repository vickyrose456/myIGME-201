
namespace unit3Test
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.turtlePictureBox = new System.Windows.Forms.PictureBox();
            this.toForm1CheckBox = new System.Windows.Forms.CheckBox();
            this.tigerPictureBox = new System.Windows.Forms.PictureBox();
            this.dogPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.turtlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tigerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // turtlePictureBox
            // 
            this.turtlePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.turtlePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("turtlePictureBox.Image")));
            this.turtlePictureBox.Location = new System.Drawing.Point(349, 91);
            this.turtlePictureBox.Name = "turtlePictureBox";
            this.turtlePictureBox.Size = new System.Drawing.Size(445, 439);
            this.turtlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turtlePictureBox.TabIndex = 0;
            this.turtlePictureBox.TabStop = false;
            // 
            // toForm1CheckBox
            // 
            this.toForm1CheckBox.AutoSize = true;
            this.toForm1CheckBox.Location = new System.Drawing.Point(96, 186);
            this.toForm1CheckBox.Name = "toForm1CheckBox";
            this.toForm1CheckBox.Size = new System.Drawing.Size(34, 33);
            this.toForm1CheckBox.TabIndex = 1;
            this.toForm1CheckBox.UseVisualStyleBackColor = true;
            // 
            // tigerPictureBox
            // 
            this.tigerPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tigerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tigerPictureBox.Image")));
            this.tigerPictureBox.Location = new System.Drawing.Point(278, 91);
            this.tigerPictureBox.Name = "tigerPictureBox";
            this.tigerPictureBox.Size = new System.Drawing.Size(625, 439);
            this.tigerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tigerPictureBox.TabIndex = 3;
            this.tigerPictureBox.TabStop = false;
            this.tigerPictureBox.Visible = false;
            // 
            // dogPictureBox
            // 
            this.dogPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox.Image")));
            this.dogPictureBox.Location = new System.Drawing.Point(293, 124);
            this.dogPictureBox.Name = "dogPictureBox";
            this.dogPictureBox.Size = new System.Drawing.Size(590, 395);
            this.dogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPictureBox.TabIndex = 4;
            this.dogPictureBox.TabStop = false;
            this.dogPictureBox.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 610);
            this.ControlBox = false;
            this.Controls.Add(this.dogPictureBox);
            this.Controls.Add(this.tigerPictureBox);
            this.Controls.Add(this.toForm1CheckBox);
            this.Controls.Add(this.turtlePictureBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turtlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tigerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox turtlePictureBox;
        private System.Windows.Forms.CheckBox toForm1CheckBox;
        private System.Windows.Forms.PictureBox tigerPictureBox;
        private System.Windows.Forms.PictureBox dogPictureBox;
    }
}