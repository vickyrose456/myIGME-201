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
        public Form1()
        {
            InitializeComponent();

            //open form 2
            //Form2 form2 = new Form2();
            //form2.ShowDialog();

            //text box delegates
            this.idTextBox.KeyPress += new KeyPressEventHandler(IdTextBox__KeyPress);
            this.passwordTextBox.KeyPress += new KeyPressEventHandler(PasswordTextBox__KeyPress);

            //set timer interval
            timer.Interval = 100;
            timer.Tick += new EventHandler(Timer__Tick);
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
            }
        }//timer tick

        private void PasswordTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {

        }//end password

        private void IdTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            //check if the user inputed "id" (not case sensitive)
            if (tb.Text.ToLower() == "id")
            {
                //correct(but show error message)
                this.errorProvider.SetError(tb, "Correct id");
                tb.Tag = false;
            }//otherwise error message
            else 
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }
            
        }
        
    }
}
