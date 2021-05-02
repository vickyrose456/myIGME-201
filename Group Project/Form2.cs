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
    public partial class Form2 : Form
    {
        public int myPort;

        public Form2(Form owner)
        {
            InitializeComponent();
            this.Owner = owner;
            this.CenterToParent();
            this.myPort = 2222;

            //login button delegate
            this.loginButton.Click += new EventHandler(LoginButton__Click);
            //username text box delegate
            this.userNameTextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__KeyPress);
        
        }

        public void LoginButton__Click(object sender, EventArgs e)
        {
            //go to the home page so that the user can send messages
            this.Close();
        }//end login button

        public void UserNameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }//username text box
    }
}
