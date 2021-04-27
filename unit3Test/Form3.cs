﻿using System;
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
        public Form3()
        {
            InitializeComponent();

            //radio button delegates
            this.friendsListRadioButton.CheckedChanged += new EventHandler(FriendsListRadioButton__CheckedChanged);
            this.directMessageRadioButton.CheckedChanged += new EventHandler(DirectMessageRadioButton__CheckChanged);
            this.latestPostRadioButton2.CheckedChanged += new EventHandler(LatestPostRadioButton2__CheckedChanged);
        }

        private void FriendsListRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = false;
        }//end friend list

        private void DirectMessageRadioButton__CheckChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = true;
            this.webBrowser1.Navigate("https://www.youtube.com/watch?v=0iCtC-EOzEo");
        }//end direct message

        private void LatestPostRadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = false;   
        }//end latest post
    }
}
