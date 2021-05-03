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
    public partial class Login : Form
    {
        Person thisPerson;


        public Login()
        {
            InitializeComponent();

           

            //controls
            this.userNametextBox.KeyPress += new KeyPressEventHandler(UserNameTextBox__Click);
        }

        private void UserNameTextBox__Click(object sender, KeyPressEventArgs e)
        {
            string userName = this.userNametextBox.Text;
            thisPerson = Globals.people[userName];
        }

    }
}
