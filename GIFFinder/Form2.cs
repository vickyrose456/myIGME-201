using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIFFinder
{
    public partial class SearchForm : Form
    {
        public string response;
        public string searchTerms;
        public int maxItems;

        public SearchForm()
        {
            
            InitializeComponent();

            this.maxItemsTextBox.KeyPress += new KeyPressEventHandler(MaxItemsTextBox__KeyPressed);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);
            this.okButton.Click += new EventHandler(OkButton__Click);

        }
        private void MaxItemsTextBox__KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.Hide();
        }
        private void OkButton__Click(object sender, EventArgs e)
        {
            this.response = "OK";

            this.searchTerms = searchTermTextBox.Text;
            this.maxItems = Convert.ToInt32(maxItemsTextBox.Text);
            this.Hide();
        }

        private void searchTermlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
