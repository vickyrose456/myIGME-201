
namespace GIFFinder
{
    partial class searchForm
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
            this.maxItemsTextBox = new System.Windows.Forms.TextBox();
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.searchTermlabel = new System.Windows.Forms.Label();
            this.maxItemslabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxItemsTextBox
            // 
            this.maxItemsTextBox.Location = new System.Drawing.Point(240, 169);
            this.maxItemsTextBox.Name = "maxItemsTextBox";
            this.maxItemsTextBox.Size = new System.Drawing.Size(309, 38);
            this.maxItemsTextBox.TabIndex = 0;
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Location = new System.Drawing.Point(240, 58);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(309, 38);
            this.searchTermTextBox.TabIndex = 1;
            // 
            // searchTermlabel
            // 
            this.searchTermlabel.AutoSize = true;
            this.searchTermlabel.Location = new System.Drawing.Point(23, 58);
            this.searchTermlabel.Name = "searchTermlabel";
            this.searchTermlabel.Size = new System.Drawing.Size(191, 32);
            this.searchTermlabel.TabIndex = 2;
            this.searchTermlabel.Text = "Search Terms";
            this.searchTermlabel.Click += new System.EventHandler(this.searchTermlabel_Click);
            // 
            // maxItemslabel
            // 
            this.maxItemslabel.AutoSize = true;
            this.maxItemslabel.Location = new System.Drawing.Point(23, 169);
            this.maxItemslabel.Name = "maxItemslabel";
            this.maxItemslabel.Size = new System.Drawing.Size(143, 32);
            this.maxItemslabel.TabIndex = 3;
            this.maxItemslabel.Text = "Max Items";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(83, 294);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(165, 52);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(340, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(165, 52);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // searchForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(646, 444);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.maxItemslabel);
            this.Controls.Add(this.searchTermlabel);
            this.Controls.Add(this.searchTermTextBox);
            this.Controls.Add(this.maxItemsTextBox);
            this.Name = "searchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxItemsTextBox;
        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.Label searchTermlabel;
        private System.Windows.Forms.Label maxItemslabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}