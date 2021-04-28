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
    public partial class Form1 : Form
    {
        bool passowordBool = false;
        bool idBool = false;
        public Form1()
        {
            InitializeComponent();

            

            //text box delegates
            this.idTextBox.KeyPress += new KeyPressEventHandler(IdTextBox__KeyPress);
            this.passwordTextBox.KeyPress += new KeyPressEventHandler(PasswordTextBox__KeyPress);

            //button delegates
            this.logInButton.Click += new EventHandler(LogInButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            //set timer interval
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer__Tick);
            //set progress bar value
            this.toolStripProgressBar.Value = 3;

        }

        private void LogInButton__Click(object sender, EventArgs e) 
        {
            //open form 2
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }//log in button

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            //Application.Exit();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.toolStripProgressBar.Value--;
            //if timer runs out
            if(this.toolStripProgressBar.Value == 0 )
            {
                //clear the password text box
                this.passwordTextBox.Text = "";
                //stop the timer
                timer.Stop();
                this.toolStripProgressBar.Value = 3;
            }
        }//timer tick

        private void checkLogin()
        {
            //if id and password = correct, exit app
            if (idBool == true && passowordBool == true)
            {
                Application.Exit();
                //this.Close();
            }
        }

        private void PasswordTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (toolStripProgressBar.Value == 3)
            {
                timer.Start();
            }

            if (passwordTextBox.Text.ToLower() == "cookies")
            {
                passowordBool = true;
                timer.Stop();
            }

            checkLogin();
        }//end password

        private void IdTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            //check if the user inputed "id" (not case sensitive)
            if (tb.Text.ToLower() == "id")
            {
                //correct(but show error message)
                this.errorProvider.SetError(tb, "Correct id");
                idBool = true;
                tb.Tag = false;
            }//otherwise error message
            else 
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }
            checkLogin();
        }//end id key press
        
    }
}
