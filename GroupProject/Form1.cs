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

namespace GroupProject
{
    public delegate void UpdateConvoDelegate(string text);

    public partial class Form1 : Form
    {
        string targetUser = "";
        string userName = "";
        string targetIp = "";
        int targetPort = 0;
        string myIp = "";
        int myPort = 2222;
        Thread thread;
        Socket listener;

        public Form1()
        {
            InitializeComponent();

            //create new login form to show that first
            Login login = new Login();
            login.ShowDialog();

            //thread start



            //ip host
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in ipHost.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }




            //control buttons
            this.friendsPictureBox.Click += new EventHandler(FriendsPictureBox__Click);
            this.sendMsgButton.Click += new EventHandler(SendMsgButton__Click);





            this.FormClosing += new FormClosingEventHandler(FormClosing__Form);

        }
        public void UpdateConversation(string text)
        {
            this.messagesRichTextBox.Text += text + "\n";
        }//update convo

        //listener fns
        public void Listen()
        {
            UpdateConvoDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConvoDelegate(UpdateConversation);
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
            if (targetIp.Length > 0)
            {
                //open a socket
                //need ip adress
                IPAddress iPAddress = IPAddress.Parse(this.targetIp);

                IPEndPoint remoteEndPoint = new IPEndPoint(iPAddress, this.targetPort);

                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //telling it to connect with ip address and port of the listener on the other end
                server.Connect(remoteEndPoint);

                Stream netStream = new NetworkStream(server);
                StreamWriter writer = new StreamWriter(netStream);

                string msg = userName + ": " + userMsgRichTextBox.Text;
                writer.Write(msg.ToCharArray(), 0, msg.Length);

                writer.Close();
                netStream.Close();
                server.Close();

                messagesRichTextBox.Text += "> " + this.targetUser + ": " + userMsgRichTextBox.Text + "\n";

                userMsgRichTextBox.Clear();

            }
        }//send button
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

