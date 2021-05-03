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

namespace Group_Project
{
    public delegate void UpdateConvo(string text);
    public partial class Form : System.Windows.Forms.Form
    {
        string targetUser = "";
        string targetIp = "";
        int targetPort = 0;
        string myIp = "";
        int myPort = 2222;
        Thread thread;
        Socket listener;

        public Form()
        {
            InitializeComponent();

            //create new login form to show that first
            Login login = new Login();
            login.ShowDialog();

            //thread start

            //control buttons
            this.friendsPictureBox.Click += new EventHandler(FriendsPictureBox__Click);
            this.sendMsgButton.Click += new EventHandler(SendMsgButton__Click);


            this.FormClosing += new FormClosingEventHandler(FormClosing__Form);

        }

        private void FormClosing__Form(object sender, FormClosingEventArgs e)
        {
            //close the listener 
            listener.Close();

            //end the thread 
            thread.Abort();

            //close the application
            Application.Exit();
        }// end form closing

        private void SendMsgButton__Click(object sender, EventArgs e)
        {
            
        }

        private void FriendsPictureBox__Click(object sender, EventArgs e)
        {
            //go to the form with the firends list

        }
        private void HomePictureBox__Click(object sender, EventArgs e)
        {
            //already on home page
        
        }//end home pic box
    }
}
