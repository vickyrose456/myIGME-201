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

            //random number txt box that takes you back to form 1
            this.toForm1CheckBox.CheckedChanged += new EventHandler(ToForm1CheckBox__CheckedChanged);

            //random number for the checkbox
            Random rand = new Random();
            this.rNum = rand.Next(1, 3);
        }

        private void ToForm1CheckBox__CheckedChanged(object sender, EventArgs e)
        {
            //open form 1 if the random number is equal to 1
            if (rNum == 1)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else //change the photo
            {
                //1. display photo
                //create new picture box 
                PictureBox photoPictureBox = new System.Windows.Forms.PictureBox();
                this.pictureBox.BackColor = System.Drawing.Color.LightGray;
                this.pictureBox.Location = new System.Drawing.Point(12, 215);
                this.pictureBox.Name = "pictureBox";
                this.pictureBox.Size = new System.Drawing.Size(162, 193);
                this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox.TabIndex = 16;
                this.pictureBox.TabStop = false;

                this.Controls.Add(photoPictureBox);

                this.pictureBox.ImageLocation = "https://image.shutterstock.com/z/stock-photo-photo-of-sea-turtle-in-the-galapagos-island-1453313555.jpg";

            }



        }//end to form 1


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
