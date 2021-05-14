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

namespace SignUp
{
    public partial class SignUp : Form
    {
        public User formPerson;
        HtmlElement htmlElement;

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


            // and only enable it if all text fields are valid
            this.createPersonButton.Enabled = false;

            

            if (parentForm != null)
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }

            this.formPerson = person;

            // we want the same delegate function to be called for the following 5 fields
            // TextBoxEmpty__Validating() is defined below
            this.userNameTextBox.Validating += new CancelEventHandler(TextBoxEmpty__Validating);
            this.passwordTextBox.Validating += new CancelEventHandler(TextBoxEmpty__Validating);

            this.userNameTextBox.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
            this.passwordTextBox.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
       
           
            this.createPersonButton.Click += new EventHandler(OkButton__Click);

            this.birthDateTimePicker.ValueChanged += new EventHandler(BirthDateTimePicker__ValueChanged);


            this.userNameTextBox.Text = person.userName;
            this.passwordTextBox.Text = person.Password;

            this.birthDateTimePicker.Value = this.birthDateTimePicker.MinDate;
            this.photoPictureBox.ImageLocation = person.photoPath;

            // if a new person being added
            if (person.userName == null)
            {
                // default to them
                this.themRadioButton.Checked = true;
            }
            else
            {
                switch (person.userGender)
                {
                    case genderPronoun.her:
                        this.herRadioButton.Checked = true;
                        break;

                    case genderPronoun.him:
                        this.himRadioButton.Checked = true;
                        break;

                    case genderPronoun.them:
                        this.themRadioButton.Checked = true;
                        break;
                }

                if (person.dateOfBirth > this.birthDateTimePicker.MinDate)
                {
                    this.birthDateTimePicker.Value = person.dateOfBirth;
                }
            }


            //if( person.GetType() == typeof(Student))
            //if (person is Student student)
            //{ }

            // show this form as non-modal
            this.Show();

            // show this form as modal
            //this.ShowDialog();
        }

        private void PhotoPictureBox__Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = openFileDialog.FileName;
            }
        }


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

        private void OkButton__Click(object sender, EventArgs e)
        {
            Student student = null;
            Teacher teacher = null;
            User person = null;

            Globals.people.Remove(this.formPerson.email);


            person.userName = this.userNameTextBox.Text;
            person.Password = this.passwordTextBox.Text;
            person.dateOfBirth = this.birthDateTimePicker.Value;
            person.photoPath = this.photoPictureBox.ImageLocation;

            if (this.herRadioButton.Checked)
            {
                person.userGender = genderPronoun.her;
            }

            if (this.himRadioButton.Checked)
            {
                person.userGender = genderPronoun.him;
            }

            if (this.themRadioButton.Checked)
            {
                person.userGender = genderPronoun.them;
            }

            // if( person is Student )
            //if (person.GetType() == typeof(Student))
            //{
                
            //}

            Globals.people[person.email] = person;

            if (this.Owner != null)
            {
                this.Owner.Enabled = true;

                this.Owner.Focus();
                try
                {
                    IListView iListView = (IListView)this.Owner;
                    iListView.PaintListView(person.email);
                }
                catch { }

            }
            formPerson = person;

            this.Hide();
            //this.Close();
            //this.Dispose();
        }

        

        private void TextNum__KeyPress(object sender, KeyPressEventArgs e)
        {
            // A key was pressed in the associated number field
            // only allow digits or a single '.' for the gpa field
            TextBox tb = (TextBox)sender;

            // e.KeyChar contains the character that was pressed
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // .NET should handle the keypress and add it to the textbox
                e.Handled = false;
            }
            else
            {
                // assume that the keystroke should not be passed on to .NET
                e.Handled = true;

            }

            ValidateAll();
        }

        private void TextBoxEmpty__TextChanged(object textField, EventArgs e)
        {
            TextBox tb = (TextBox)textField;

            if (tb.Text.Length == 0)
            {
                this.errorProvider1.SetError(tb, "This field cannot be empty.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void ValidateAll()
        {
            this.createPersonButton.Enabled =
                (bool)this.userNameTextBox.Tag &&
                (bool)this.passwordTextBox.Tag;
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                // enable the parent
                this.Owner.Enabled = true;

                // and set it into focus to process mouse and keyboard events
                this.Owner.Focus();
            }

            // close this form
            this.Close();
            this.Dispose();
        }

        private void TextBoxEmpty__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                // show error
                this.errorProvider1.SetError(tb, "This field cannot be empty.");

                // cancel moving to the next field
                e.Cancel = true;

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                this.errorProvider1.SetError(tb, null);
                e.Cancel = false;

                // set the control to being valid
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
