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

namespace GroupProject
{
    public partial class Login : Form
    {
        Person thisPerson;

        //store username
        string userName = "";

        public Login()
        {
            InitializeComponent();


            //controls
            this.userNametextBox.KeyPress += new KeyPressEventHandler(UserNametextBox__Click);
        }

        private void UserNameTextBox__Click(object sender, KeyPressEventArgs e)
        {
            userName = this.userNametextBox.Text;
        }

        public AddNewPerson(string name)
        {
            
        }
    }
}
