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
            /*
            //show this form
            //this.Show();

            //call the login form by creating a new one
            Form2 loginForm = new Form2(this);
            //only want active one to show(pause constructor)
            //loginForm.ShowDialog();

            //thread start
            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
            thread.Start();

            //Get the host for the messages
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in ipHost.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }


            //change cursor of home pic box
            this.homePictureBox.Cursor = Cursors.Arrow;

            //event handlers for controls
            this.homePictureBox.Click += new EventHandler(HomePictureBox__Click);
        }

        public void UpdateConversation(string text)
        {
            this.messagesRichTextBox.Text += text + "\n";
        }//update convo

        private void Listen()
        {
            UpdateConvo updateConversation;
            updateConversation = new UpdateConvo(UpdateConversation);
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
                Invoke(updateConversation, result);
                reader.Close();
                netStream.Close();
                client.Close();
            }
        }

        private void HomePictureBox__Click(object sender, EventArgs e)
        {
            //already on home page
        */
        }//en home pic box
    }
}
