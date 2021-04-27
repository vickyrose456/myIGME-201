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

            //
            //Form2 form2 = new Form2();
            //form2.ShowDialog();

            //text box delegates
            this.idTextBox.KeyPress += new KeyPressEventHandler(IdTextBox__KeyPress);
            //this.passwordTextBox.KeyPress += new EventHandler(PasswordTextBox__KeyPress);

        }
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
