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
        User myUser;
        public FriendsList()
        {
            InitializeComponent();
            Globals.AddPeopleData();


            this.teacherButton.Click += new EventHandler(TeacherButton__Click);
            this.studentsButton.Click += new EventHandler(StudentsButton__Click);
            this.homePictureBox.Click += new EventHandler(HomePictureBox__Click);
            //this.groupBox1.Visible = false;

        }//friendslist
        private void TeacherButton__Click(object sender, EventArgs e)
        {
            //clearing array of controls assoc w/ panel
            this.flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, User> keyValuePair in Globals.people.myList)
            {
                if (keyValuePair.Value.GetType() == typeof(Teacher))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            teacherButton.Text = this.flowLayoutPanel1.Controls.Count.ToString();

            
        }
        private void StudentsButton__Click(object sender, EventArgs e)
        {
            //clearing array of controls assoc w/ panel
            this.flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, User> keyValuePair in Globals.people.myList)
            {
                if (keyValuePair.Value.GetType() == typeof(Student))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            studentsButton.Text = this.flowLayoutPanel1.Controls.Count.ToString();
        }


        public void AddPanel(User user)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            //add the person to the panel
            AddPersonToPanel(ref panel1, user);

            this.flowLayoutPanel1.Controls.Add(panel1);

            //show the children
            this.flowLayoutPanel1.Controls.SetChildIndex(panel1, flowLayoutPanel1.Controls.Count);
        }

        private void AddPersonToPanel(ref Panel panel1, User person)
        {
            Label userNameLabel = new System.Windows.Forms.Label();
            GroupBox photoGroupBox = new System.Windows.Forms.GroupBox();
            PictureBox photoPictureBox = new System.Windows.Forms.PictureBox();

            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(86, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1164, 617);
            this.flowLayoutPanel1.TabIndex = 17;
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
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.photoPictureBox.Location = new System.Drawing.Point(21, 120);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(176, 143);
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";

        }//end add person to panel
       private void HomePictureBox__Click(object sender, EventArgs e)
        {
            this.Close();
            //go to the form with the firends list
            Form1 messages = new Form1();
            messages.ShowDialog();
            

        }
    }

    

}
