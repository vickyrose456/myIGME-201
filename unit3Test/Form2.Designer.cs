
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toForm1CheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Location = new System.Drawing.Point(349, 91);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(445, 439);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // toForm1CheckBox
            // 
            this.toForm1CheckBox.AutoSize = true;
            this.toForm1CheckBox.Location = new System.Drawing.Point(144, 161);
            this.toForm1CheckBox.Name = "toForm1CheckBox";
            this.toForm1CheckBox.Size = new System.Drawing.Size(34, 33);
            this.toForm1CheckBox.TabIndex = 1;
            this.toForm1CheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(144, 380);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(34, 33);
            this.checkBox.TabIndex = 2;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 610);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.toForm1CheckBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox toForm1CheckBox;
        private System.Windows.Forms.CheckBox checkBox;
    }
}