using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sherlock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //disable exit button
            this.exitButton.Enabled = false;

            //exitButton.Click += ExitButton__Click
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            //
            //hide the 2 PictureBoxes
            //
            this.sadPictureBox.Visible = false;
            this.happyPictureBox.Visible = false;


            //label.Text = "The quick brown fox jumped over the lazy dog"
            //

            //hide the countdown label
            this.countdownLabel.Visible = false;

            //countdownLabel.Text = "20"
            this.countdownLabel.Text = "20";

            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
            webBrowser1.Navigate("https://people.rit.edu/dxsigm/sherlock.html");
            

            

            //
            textBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);


            timer1.Interval = 1000;

            timer1.Tick += new EventHandler(Timer__Tick);
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            // if the 20 seconds elapsed
            //if labelText == "1"
            if( countdownLabel.Text == "1" )
            {
                // stop the timer
                timer1.Stop();

                // set label text to invisible
                countdownLabel.Visible = false;

                // reset label text to "20"
                countdownLabel.Text = "20";

                // hide both pictureboxes
                this.sadPictureBox.Visible = false;
                this.happyPictureBox.Visible = false;

                // clear any progress
                textBox.Text = "";
            }
            else
            {
                countdownLabel.Text = (Int32.Parse(countdownLabel.Text) - 1).ToString();
            }
        }


        private void TextBox__KeyPress( object sender, KeyPressEventArgs e )
        {
            if (countdownLabel.Text == "20")
            {
                //start the timer
                timer1.Start();
                countdownLabel.Visible = true;
            }

            //if they pressed the next character in label.Text
            if (quickLabel.Text[textBox.TextLength] == e.KeyChar)
            {
                //allow the character to pass to .NET(ie.show in the TextBox)
                e.Handled = false;

                happyPictureBox.Visible = true;

                sadPictureBox.Visible = false;

                // if they typed the whole labelText
                //if the textBox.Text + e.KeyChar == labelText
                if (textBox.Text + e.KeyChar == quickLabel.Text)
                {
                    exitButton.Enabled = true;

                    // remove the KeyPress event handler
                    textBox.KeyPress -= new KeyPressEventHandler(TextBox__KeyPress);

                    //timer1.Stop();
                }
            }
	        else
	        {
                // do not allow the character to pass to.NET
                // so that it will not show in the TextBox(ie.e.Handled = true)
                e.Handled = true;

                // show the sad picture box
                sadPictureBox.Visible = true;

                // hide the happy picture box
                happyPictureBox.Visible = false;
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // get collection of HtmlElements(HtmlElementCollection) which are anchor tags
            HtmlElementCollection htmlElementCollection = webBrowser1.Document.GetElementsByTagName("a");

            foreach (HtmlElement link in htmlElementCollection)
            {
                link.Click += new HtmlElementEventHandler(Link__Click);
            }

            // because the links cause this to be called after each click
            // remove the this event handler from the WebBrowser control
            webBrowser1.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
        }

        private void Link__Click(object sender, HtmlElementEventArgs e)
        {
            HtmlElement link = (HtmlElement)sender;

            if( link.InnerText.ToLower().Contains("click me"))
            {
                link.InnerText = "You clicked me!";
                link.Style = "color:blue; font-size: 1.5rem;";
            }
            else if( link.InnerText.ToLower().Contains("clicked me!") )
            {
                link.InnerText = "You clicked me again.  Now stop it.";
                link.Style = "color:red; font-size: 2rem;";
            }
            else 
            {
                link.InnerText = "I asked you to stop it.";
                link.Style = "color:purple; font-size: 2.5rem;";
                link.Click -= new HtmlElementEventHandler(Link__Click);
            }
        }


    }
}
