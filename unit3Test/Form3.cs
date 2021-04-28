using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unit3Test
{
    public partial class Form3 : Form
    {
            int rNum1;
            int rNum2;

        public Form3()
        {
            InitializeComponent();

            //radio button delegates
            this.friendsListRadioButton.CheckedChanged += new EventHandler(FriendsListRadioButton__CheckedChanged);
            this.directMessageRadioButton.CheckedChanged += new EventHandler(DirectMessageRadioButton__CheckChanged);
            this.latestPostRadioButton2.CheckedChanged += new EventHandler(LatestPostRadioButton2__CheckedChanged);

            //key press for message box
            this.messageTextBox.KeyPress += new KeyPressEventHandler(MessageTextBox__KeyPress);
        
            
        }

        private void MessageTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            //replace "s", "t" and "a" with ""
            TextBox tb = (TextBox)sender;

            //make the radio buttons dissappear when "s" is typed
            if (e.KeyChar.ToString().ToLower() == "s")
            {
                e.Handled = false;
                this.optionsGroupBox.Visible = false;
                this.messageTextBox.BackColor = Color.Black;
                this.messageTextBox.ForeColor = Color.White;
            }
            //if "t" or "a" is pressed, then the text box will not type it
            if (e.KeyChar.ToString().ToLower() == "a" || e.KeyChar.ToString().ToLower() == "t")
            {
                this.messageTextBox.BackColor = Color.Red;
                e.Handled = true;
            }
        }

        private void FriendsListRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            rNum1 = rand.Next(20, 300);
            rNum2 = rand.Next(5, 300);

            //closes the youtube video section
            this.webBrowser1.Visible = false;
            //message box is invisible
            this.groupBox1.Visible = false;

            //resets the radio buttons size and location
            this.friendsListRadioButton.Location = new System.Drawing.Point(rNum2, rNum1);
            // 
            // latestPostRadioButton2
            // 
            rNum1 = rand.Next(20, 500);
            rNum2 = rand.Next(5, 100);
            this.latestPostRadioButton2.Location = new System.Drawing.Point(rNum2, rNum1);
            // 
            // directMessageRadioButton
            // 
            rNum1 = rand.Next(20, 500);
            rNum2 = rand.Next(5, 100);
            this.directMessageRadioButton.AutoSize = true;
            this.directMessageRadioButton.Location = new System.Drawing.Point(rNum2, rNum1);


        }//end friend list

        private void DirectMessageRadioButton__CheckChanged(object sender, EventArgs e)
        {
            // shows the youtube video
            this.webBrowser1.Visible = true;
            this.webBrowser1.Navigate("https://www.youtube.com/watch?v=0iCtC-EOzEo");

            //message is not visible
            this.groupBox1.Visible = false;
        }//end direct message

        private void LatestPostRadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            //close youtube video
            this.webBrowser1.Visible = false;
            //make group box appear
            this.groupBox1.Visible = true;

        }//end latest post

        private void Form3__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {
                this.Close();
            }
        }
    }
}
