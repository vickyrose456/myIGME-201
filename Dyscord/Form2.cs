using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Dyscord
{
    public partial class DyscordForm : Form
    {
            /*
             * •	string targetUser; : the username to communicate with
                •	string targetIp; : the ip address of the user to communicate with
                •	int targetPort; : the port of the user to communicate with
                •	string myIp; : your ip address
                •	int myPort; : my listener port
                •	Thread thread:
                •	Socket listener;*/

        string targetUser;
        string targetTip;
        int targetPort;
        string myIp;
        int myPort;
        Thread thread;
        Socket listener;

        public DyscordForm()
        {
            InitializeComponent();

            this.Show();
            SettingsForm settingsForm = new SettingsForm(this, myPort);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
