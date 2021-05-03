using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //controls
            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.uerNameTextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__KeyPress);
        }
        private void LoginButton__Click(object sender, EventArgs e)
        {
            //Close this form when logging in
            this.Close();
        }

        private void UserNameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            //check if the user didnt type anything
            if (tb.Text.ToLower() == "" || tb.Text == null)
            {
                //correct(but show error message)
                this.errorProvider.SetError(tb, "Invlid id");
                tb.Tag = false;
            }//otherwise no error message
            else
            {
                //set error message to null
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }
        }
    }
}
