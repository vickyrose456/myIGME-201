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
    public delegate void UpdateConversationDelegate(string text);

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
            //want it to be the only active one (pause constructor to get new port setting)
            settingsForm.ShowDialog();
            
            this.myPort = settingsForm.myPort;

            //thread start 
            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
        }
        public void UpdateConversation(string text)
        {
            this.convGroupBox.Text += text + "\n";
        }

        public void Listen()
        {
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(UpdateConversation);
            //no matter IP adress, it will process it
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, this.myPort);

            //tcp ~ phone line
            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(serverEndPoint);

            listener.Listen(300);

            //cont. listen for connections
            while (true)
            {
                Socket client = listener.Accept();
                Stream netStream = new NetworkStream(client);
                StreamReader reader = new StreamReader(netStream);

                //reads to full content and returns as string
                string result = reader.ReadToEnd();
                //put msg into textbox [does not have direct access to parent method]
                //can use invoke of delegate method
                Invoke(updateConversationDelegate, result);
                reader.Close();
                netStream.Close();
                client.Close();
            }
        }//end listen

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
