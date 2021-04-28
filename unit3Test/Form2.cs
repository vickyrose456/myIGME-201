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
            this.turtlePictureBox.MouseClick += new MouseEventHandler(PictureBox__MouseClick);
            this.tigerPictureBox.MouseClick += new MouseEventHandler(PictureBox__MouseClick);
            this.dogPictureBox.MouseClick += new MouseEventHandler(PictureBox__MouseClick);

            //random number txt box that takes you back to form 1
            this.toForm1CheckBox.CheckedChanged += new EventHandler(ToForm1CheckBox__CheckedChanged);

            //random number for the checkbox
            //Random rand = new Random();
            //this.rNum = rand.Next(1, 3);
        }

        private void ToForm1CheckBox__CheckedChanged(object sender, EventArgs e)
        {
            //gen random number
            Random rand = new Random();
            this.rNum = rand.Next(1, 3);

            //open form 1 if the random number is equal to 1
            if (rNum == 1)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();

                //change the photo to the dogs
                this.turtlePictureBox.Visible = false;
                this.tigerPictureBox.Visible = false;
                this.dogPictureBox.Visible = true;
               
            }
            else if (rNum == 2)//change the photo
            {
                //change photo to tiger
                this.turtlePictureBox.Visible = false;
                this.tigerPictureBox.Visible = true;
                this.dogPictureBox.Visible = false;

            }
            else
            {
                //change photo to turtle
                 this.turtlePictureBox.Visible = true;
                this.tigerPictureBox.Visible = false;
                this.dogPictureBox.Visible = false;
            }



        }//end to form 1


        private void PictureBox__MouseClick(object sender, EventArgs e)
        {
            picClicks++;
            //click the pic 3 times to make form 3 pop up
            if (picClicks == 2)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                picClicks = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
