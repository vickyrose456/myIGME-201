namespace EditPerson
{
    partial class PersonEditForm
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
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.licLabel = new System.Windows.Forms.Label();
            this.licText = new System.Windows.Forms.TextBox();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.specText = new System.Windows.Forms.TextBox();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.themRadioButton = new System.Windows.Forms.RadioButton();
            this.herRadioButton = new System.Windows.Forms.RadioButton();
            this.himRadioButton = new System.Windows.Forms.RadioButton();
            this.classBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophRadioButton = new System.Windows.Forms.RadioButton();
            this.freshRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.genderGroupBox.SuspendLayout();
            this.classBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typeLabel.Location = new System.Drawing.Point(24, 48);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(187, 31);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Person type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.typeComboBox.Location = new System.Drawing.Point(213, 43);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(311, 39);
            this.typeComboBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(24, 131);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(187, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.Location = new System.Drawing.Point(213, 126);
            this.nameText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(545, 38);
            this.nameText.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(24, 219);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(187, 31);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailText.Location = new System.Drawing.Point(213, 212);
            this.emailText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(932, 38);
            this.emailText.TabIndex = 2;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageLabel.Location = new System.Drawing.Point(24, 312);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(187, 31);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age:";
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageText.Location = new System.Drawing.Point(213, 305);
            this.ageText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(153, 38);
            this.ageText.TabIndex = 3;
            // 
            // licLabel
            // 
            this.licLabel.BackColor = System.Drawing.Color.Transparent;
            this.licLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.licLabel.Location = new System.Drawing.Point(24, 408);
            this.licLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.licLabel.Name = "licLabel";
            this.licLabel.Size = new System.Drawing.Size(187, 31);
            this.licLabel.TabIndex = 4;
            this.licLabel.Text = "License Id:";
            // 
            // licText
            // 
            this.licText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licText.Location = new System.Drawing.Point(213, 403);
            this.licText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.licText.Name = "licText";
            this.licText.Size = new System.Drawing.Size(311, 38);
            this.licText.TabIndex = 4;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialtyLabel.Location = new System.Drawing.Point(24, 501);
            this.specialtyLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(187, 31);
            this.specialtyLabel.TabIndex = 5;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // specText
            // 
            this.specText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.specText.Location = new System.Drawing.Point(213, 494);
            this.specText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.specText.Name = "specText";
            this.specText.Size = new System.Drawing.Size(932, 38);
            this.specText.TabIndex = 5;
            // 
            // gpaLabel
            // 
            this.gpaLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpaLabel.Location = new System.Drawing.Point(24, 501);
            this.gpaLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(160, 31);
            this.gpaLabel.TabIndex = 6;
            this.gpaLabel.Text = "GPA:";
            // 
            // gpaText
            // 
            this.gpaText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpaText.Location = new System.Drawing.Point(213, 494);
            this.gpaText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(153, 38);
            this.gpaText.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(1442, 579);
            this.okButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(149, 57);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(1657, 579);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 57);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.themRadioButton);
            this.genderGroupBox.Controls.Add(this.herRadioButton);
            this.genderGroupBox.Controls.Add(this.himRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(1182, 126);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(228, 236);
            this.genderGroupBox.TabIndex = 6;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Gender";
            this.genderGroupBox.Enter += new System.EventHandler(this.genderBox_Enter);
            // 
            // themRadioButton
            // 
            this.themRadioButton.AutoSize = true;
            this.themRadioButton.Location = new System.Drawing.Point(22, 168);
            this.themRadioButton.Name = "themRadioButton";
            this.themRadioButton.Size = new System.Drawing.Size(124, 36);
            this.themRadioButton.TabIndex = 14;
            this.themRadioButton.TabStop = true;
            this.themRadioButton.Text = "Them";
            this.themRadioButton.UseVisualStyleBackColor = true;
            // 
            // herRadioButton
            // 
            this.herRadioButton.AutoSize = true;
            this.herRadioButton.Location = new System.Drawing.Point(22, 108);
            this.herRadioButton.Name = "herRadioButton";
            this.herRadioButton.Size = new System.Drawing.Size(97, 36);
            this.herRadioButton.TabIndex = 13;
            this.herRadioButton.TabStop = true;
            this.herRadioButton.Text = "Her";
            this.herRadioButton.UseVisualStyleBackColor = true;
            // 
            // himRadioButton
            // 
            this.himRadioButton.AutoSize = true;
            this.himRadioButton.Location = new System.Drawing.Point(22, 48);
            this.himRadioButton.Name = "himRadioButton";
            this.himRadioButton.Size = new System.Drawing.Size(102, 36);
            this.himRadioButton.TabIndex = 12;
            this.himRadioButton.TabStop = true;
            this.himRadioButton.Text = "Him";
            this.himRadioButton.UseVisualStyleBackColor = true;
            this.himRadioButton.CheckedChanged += new System.EventHandler(this.himButton_CheckedChanged);
            // 
            // classBox
            // 
            this.classBox.Controls.Add(this.label1);
            this.classBox.Controls.Add(this.seniorRadioButton);
            this.classBox.Controls.Add(this.juniorRadioButton);
            this.classBox.Controls.Add(this.sophRadioButton);
            this.classBox.Controls.Add(this.freshRadioButton);
            this.classBox.Location = new System.Drawing.Point(1469, 126);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(350, 377);
            this.classBox.TabIndex = 7;
            this.classBox.TabStop = false;
            this.classBox.Text = "Class";
            this.classBox.Enter += new System.EventHandler(this.classBox_Enter);
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(23, 230);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(135, 36);
            this.seniorRadioButton.TabIndex = 20;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(23, 168);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(130, 36);
            this.juniorRadioButton.TabIndex = 19;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophRadioButton
            // 
            this.sophRadioButton.AutoSize = true;
            this.sophRadioButton.Location = new System.Drawing.Point(23, 108);
            this.sophRadioButton.Name = "sophRadioButton";
            this.sophRadioButton.Size = new System.Drawing.Size(183, 36);
            this.sophRadioButton.TabIndex = 18;
            this.sophRadioButton.TabStop = true;
            this.sophRadioButton.Text = "Sophmore";
            this.sophRadioButton.UseVisualStyleBackColor = true;
            // 
            // freshRadioButton
            // 
            this.freshRadioButton.AutoSize = true;
            this.freshRadioButton.Location = new System.Drawing.Point(23, 48);
            this.freshRadioButton.Name = "freshRadioButton";
            this.freshRadioButton.Size = new System.Drawing.Size(179, 36);
            this.freshRadioButton.TabIndex = 17;
            this.freshRadioButton.TabStop = true;
            this.freshRadioButton.Text = "Freshman";
            this.freshRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Class of 9999";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1836, 695);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.specText);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.licText);
            this.Controls.Add(this.licLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.gpaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1872, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1172, 633);
            this.Name = "PersonEditForm";
            this.Text = "Edit Person";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.classBox.ResumeLayout(false);
            this.classBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label licLabel;
        private System.Windows.Forms.TextBox licText;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.TextBox specText;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox classBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophRadioButton;
        private System.Windows.Forms.RadioButton freshRadioButton;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton themRadioButton;
        private System.Windows.Forms.RadioButton herRadioButton;
        private System.Windows.Forms.RadioButton himRadioButton;
        private System.Windows.Forms.Label label1;
    }
}

