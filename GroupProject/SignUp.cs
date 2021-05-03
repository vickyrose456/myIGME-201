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
        public SignUp()
        {
            InitializeComponent();

            //controls
            this.userNameTextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__KeyPress);
            this.passwordTextBox.KeyPress += new KeyPressEventHandler(PasswordTextBox__KeyPress);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

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
