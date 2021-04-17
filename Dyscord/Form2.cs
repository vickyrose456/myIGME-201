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

        string targetUser = "";
        string targetIp = "";
        int targetPort = 0;
        string myIp = "";
        int myPort = 0;
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
            thread.Start();

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in ipHost.AddressList)
            {
                if(iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }


            //event handlers for bttns
            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.sendButton.Click += new EventHandler(SendButton__Click);
            this.usersButton.Click += new EventHandler(UsersButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
        }
        public void UpdateConversation(string text)
        {
            this.convGroupBox.Text += text + "\n";
        }//update convo

        private void LoginButton__Click(object sender, EventArgs e)
        {
            //should only do this if they use their username
            if(userTextBox.TextLength >0)
            {
                webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?login=" + userTextBox.Text + "&ip=" + myIp + ":" + myPort);
                webBrowser1.Visible = false;
                userTextBox.Enabled = false;
                loginButton.Enabled = false;
            }
        }//login btn

        private void UsersButton__Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?login=");
            webBrowser1.Visible = true;
            convRichTextBox.SendToBack();
        }//end users

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement htmlElement in htmlElementCollection)
            {
                htmlElement.Click += new HtmlElementEventHandler(HtmlElement__Click);
            }
        }//end web doc completed

        private void HtmlElement__Click(object sender, HtmlElementEventArgs e)
        {
            string title;
            string[] ipPort;

            HtmlElement htmlElement = (HtmlElement)sender;

            title = htmlElement.GetAttribute("title");
            ipPort = title.Split(':');
            this.targetIp = ipPort[0];
            this.targetPort = Int32.Parse(ipPort[1]);

            this.targetUser = htmlElement.GetAttribute("name");
            this.convGroupBox.Text = "Conversing with " + targetUser;

            webBrowser1.Visible = false;
            webBrowser1.SendToBack();
        }//html elem click

        private void SendButton__Click(object sender, EventArgs e)
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

                string msg = userTextBox + ": " + msgRichTextBox.Text;
                writer.Write(msg.ToCharArray(), 0, msg.Length);

                writer.Close();
                netStream.Close();
                server.Close();

                this.convRichTextBox.Text += "> " + this.targetUser + ": " + msgRichTextBox.Text + "\n";

                msgRichTextBox.Clear();

            }
        }//send button

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

        private void ExitButton__Click(object sender, EventArgs e)
        {
            listener.Close();

            thread.Abort();

            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
