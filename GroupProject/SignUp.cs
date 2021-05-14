using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TigerChatPeopleLib;
using TigerUsersGlobals;

namespace GroupProject
{
    public partial class SignUp : Form
    {/*
        User formUser;
        public SignUp(User person, Form parentForm)
        {
            InitializeComponent();

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            if (parentForm != null)
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }
            this.formUser = person;


            //controls
            this.userNameTextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__KeyPress);
            this.passwordTextBox.KeyPress += new KeyPressEventHandler(PasswordTextBox__KeyPress);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.createPersonButton.Click += new EventHandler(CreatePersonButton__Click);


            this.himRadioButton.CheckedChanged += new EventHandler(GenderRadioButton__CheckedChanged);
            this.herRadioButton.CheckedChanged += new EventHandler(GenderRadioButton__CheckedChanged);
            this.themRadioButton.CheckedChanged += new EventHandler(GenderRadioButton__CheckedChanged);

            this.birthDateTimePicker.ValueChanged += new EventHandler(this.BirthDateTimePicker__ValueChanged);

            //deactivate sign up until the user puts all info
            this.createPersonButton.Enabled = false;

            this.birthDateTimePicker.Value = this.birthDateTimePicker.MinDate;
            if (person.dateOfBirth > this.birthDateTimePicker.MinDate)
            {
                this.birthDateTimePicker.Value = person.dateOfBirth;
            }

            //if( person.GetType() == typeof(Student))
            if (person is Student student)
            {
                this.typeComboBox.SelectedIndex = 0;
                //Student student = (Student)person;
                this.gpaText.Text = student.gpa.ToString();


            }
            else
            {
                this.typeComboBox.SelectedIndex = 1;
                Teacher teacher = (Teacher)person;
                this.specText.Text = teacher.specialty;
            }


            // show this form as non-modal
            this.Show();

        }//sign up

        private void BirthDateTimePicker__ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.Value == dtp.MinDate)
            {
                dtp.CustomFormat = " ";
            }
            else 
            {
                dtp.CustomFormat = "MMM d, yyyy";
            }
        }

        private void GenderRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb == this.himRadioButton)
            {
                //set the gender to him
                formUser.userGender = genderPronoun.him;
            }
            if(rb == this.herRadioButton)
            {
                //set the gender to her
                formUser.userGender = genderPronoun.her;
            }
            if (rb == this.themRadioButton)
            {
                //set gender to them
                formUser.userGender = genderPronoun.them;
            }
        }
        private void CreatePersonButton__Click(object sender, EventArgs e)
        {
            User person = null;

            IUser iUser = (IUser)formUser;

            
            People newUser = new People();
            person = newUser;

            //asssign the values to the person
            person.userName = this.userNameTextBox.Text;
            person.Password = this.passwordTextBox.Text;
            person.dateOfBirth = this.birthDateTimePicker.Value;

            //close this form
            this.Close();
            ParentForm.Enabled = true;
        }

        private void UserNameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //while it isnt empty, store it into the person
            if (tb.Text == null || tb.Text.Length <= 2)
            {
                //show error message
                this.errorProvider1.SetError(tb, "Invalid username");
                tb.Tag = false;

            }
            else 
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;

                //set the text to the username
                formUser.userName = tb.Text;
            }
        }

        private void PasswordTextBox__KeyPress (object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //while it isnt empty, store it into the person
            if (tb.Text == null || tb.Text.Length <= 2)
            {
           
                //show error message
                this.errorProvider1.SetError(tb, "Invalid password");
                tb.Tag = false;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;

                //set the text to the password
                formUser.Password = tb.Text;
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
}
