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
        public SignUp(Person person, Form parentForm)
        {
            InitializeComponent();


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



            this.himRadioButton.CheckedChanged += new EventHandler(this.GenderRadioButton__CheckedChanged);
            this.herRadioButton.CheckedChanged += new EventHandler(this.GenderRadioButton__CheckedChanged);
            this.themRadioButton.CheckedChanged += new EventHandler(this.GenderRadioButton__CheckedChanged);

        }

        private void GenderRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void CreatePersonButton__Click(object sender, EventArgs e)
        {
            //close thi form
            this.Close();
        }

        private void UserNameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
           //while it isnt empty, store it into the person

        }

        private void PasswordTextBox__KeyPress (object sender, KeyPressEventArgs e)
        {
            //associate this password with this user
            
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
