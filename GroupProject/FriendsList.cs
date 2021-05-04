using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TigerChatPeopleLib;
using TigerUsersGlobals;

namespace GroupProject
{
    public partial class FriendsList : Form
    {
        public FriendsList()
        {
            InitializeComponent();
            Globals.AddPeopleData();

            this.flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, Person> keyValuePair in Globals.people.myList)
            {
                if (keyValuePair.Value.GetType() == typeof(User))
                {
                    AddPanel(keyValuePair.Value);
                }
            }
        }

        public void AddPanel(Person person)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            //add the person to the panel
            AddPersonToPanel(ref panel1, person);

            this.flowLayoutPanel1.Controls.Add(panel1);

            //show the children
            this.flowLayoutPanel1.Controls.Add(panel1);
        }

        private void AddPersonToPanel(ref Panel panel1, Person person)
        {
            Label userNameLabel = new System.Windows.Forms.Label();
            GroupBox photoGroupBox = new System.Windows.Forms.GroupBox();
            PictureBox photoPictureBox = new System.Windows.Forms.PictureBox();

            //panel 1
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1164, 617);
            this.flowLayoutPanel1.TabIndex = 17;

            //uername label
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";

            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.photoPictureBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 330);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";

            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(77, 116);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(176, 143);
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;


        }//end add person to panel
    }

}
