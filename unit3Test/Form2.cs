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
    public partial class Form2 : Form
    {
        int picClicks = 0;
        public int rNum;

        public Form2()
        {
            InitializeComponent();

            //picturebox delegate
            this.pictureBox.MouseClick += new MouseEventHandler(PictureBox__MouseClick);

            Random rand = new Random();
            this.rNum = rand.Next(1, 3);
        }

        private void PictureBox__MouseClick(object sender, EventArgs e)
        {
            picClicks++;
            if (picClicks == 3)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                picClicks = 0;
            }
        }
    }
}
