﻿namespace CourseList
{
    partial class CourseListForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.courseCodeTextBox = new System.Windows.Forms.TextBox();
            this.courseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.reviewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.courseListView = new System.Windows.Forms.ListView();
            this.codeHer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dowHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(1955, 904);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 57);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1683, 904);
            this.updateButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(149, 57);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // courseCodeTextBox
            // 
            this.courseCodeTextBox.BackColor = System.Drawing.Color.White;
            this.courseCodeTextBox.Location = new System.Drawing.Point(243, 911);
            this.courseCodeTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.courseCodeTextBox.Name = "courseCodeTextBox";
            this.courseCodeTextBox.Size = new System.Drawing.Size(244, 38);
            this.courseCodeTextBox.TabIndex = 11;
            // 
            // courseDescriptionTextBox
            // 
            this.courseDescriptionTextBox.Location = new System.Drawing.Point(781, 911);
            this.courseDescriptionTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.courseDescriptionTextBox.Name = "courseDescriptionTextBox";
            this.courseDescriptionTextBox.Size = new System.Drawing.Size(772, 38);
            this.courseDescriptionTextBox.TabIndex = 12;
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Location = new System.Drawing.Point(32, 918);
            this.courseCodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(189, 32);
            this.courseCodeLabel.TabIndex = 13;
            this.courseCodeLabel.Text = "Course Code:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(595, 918);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(166, 32);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description:";
            // 
            // reviewRichTextBox
            // 
            this.reviewRichTextBox.Location = new System.Drawing.Point(243, 994);
            this.reviewRichTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.reviewRichTextBox.Name = "reviewRichTextBox";
            this.reviewRichTextBox.Size = new System.Drawing.Size(1311, 176);
            this.reviewRichTextBox.TabIndex = 15;
            this.reviewRichTextBox.Text = "";
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Location = new System.Drawing.Point(32, 1002);
            this.reviewLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(116, 32);
            this.reviewLabel.TabIndex = 16;
            this.reviewLabel.Text = "Review:";
            // 
            // courseListView
            // 
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeHer,
            this.descHdr,
            this.instructorName,
            this.dowHdr,
            this.timeHdr});
            this.courseListView.FullRowSelect = true;
            this.courseListView.HideSelection = false;
            this.courseListView.Location = new System.Drawing.Point(1, 2);
            this.courseListView.MultiSelect = false;
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(2103, 853);
            this.courseListView.TabIndex = 1;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            // 
            // codeHer
            // 
            this.codeHer.Text = "Code";
            this.codeHer.Width = 180;
            // 
            // descHdr
            // 
            this.descHdr.Text = "Description";
            this.descHdr.Width = 250;
            // 
            // instructorName
            // 
            this.instructorName.Text = "Instructor";
            this.instructorName.Width = 175;
            // 
            // dowHdr
            // 
            this.dowHdr.Text = "Days";
            this.dowHdr.Width = 100;
            // 
            // timeHdr
            // 
            this.timeHdr.Text = "Time";
            this.timeHdr.Width = 300;
            // 
            // CourseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(2133, 1289);
            this.Controls.Add(this.courseListView);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.reviewRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.courseCodeLabel);
            this.Controls.Add(this.courseDescriptionTextBox);
            this.Controls.Add(this.courseCodeTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CourseListForm";
            this.Text = "Course List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox courseCodeTextBox;
        private System.Windows.Forms.TextBox courseDescriptionTextBox;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox reviewRichTextBox;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader codeHer;
        private System.Windows.Forms.ColumnHeader descHdr;
        private System.Windows.Forms.ColumnHeader instructorName;
        private System.Windows.Forms.ColumnHeader dowHdr;
        private System.Windows.Forms.ColumnHeader timeHdr;
    }
}

