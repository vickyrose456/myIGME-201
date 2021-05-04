﻿using System;
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
    public partial class Login : Form
    {
        Person thisPerson;


        public Login()
        {
            InitializeComponent();

            //controls
            this.userNametextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__Click);
            this.signUpButton.Click += new EventHandler(SignUpButton__Click);
            
            Globals.AddPeopleData();
        }

        private void UserNameTextBox__Click(object sender, KeyPressEventArgs e)
        {
            //set the person username to the username entered in the textbox
            TextBox tb = (TextBox)sender;

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
            }
        }

        private void SignUpButton__Click(object sender, EventArgs e)
        {
            //create new user
            User newUser = new User();
            //close the form
            this.Enabled = false;

            //create a signupform to add the new person
            //new SignUp(newUser, this);
            SignUp signUpForm = new SignUp(newUser, this);
            signUpForm.ShowDialog();
        }

    }
}
