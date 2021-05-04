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
    {
        Person formUser;
        public SignUp(Form parentForm)
        {
            InitializeComponent();


            if (parentForm != null)
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }


            //controls
            this.userNameTextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__KeyPress);
            this.passwordTextBox.KeyPress += new KeyPressEventHandler(PasswordTextBox__KeyPress);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.createPersonButton.Click += new EventHandler(CreatePersonButton__Click);


            this.himRadioButton.CheckedChanged += new EventHandler(this.GenderRadioButton__CheckedChanged);
            this.herRadioButton.CheckedChanged += new EventHandler(this.GenderRadioButton__CheckedChanged);
            this.themRadioButton.CheckedChanged += new EventHandler(this.GenderRadioButton__CheckedChanged);

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
                formUser.UserPassword = tb.Text;
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
