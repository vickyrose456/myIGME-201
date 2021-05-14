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


            this.teacherButton.Click += new EventHandler(TeacherButton__Click);
            this.studentsButton.Click += new EventHandler(StudentsButton__Click);
            this.homePictureBox.Click += new EventHandler(HomePictureBox__Click);

            this.panel1.Visible = false;




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
            //create a new panel
            Panel panel1 = new System.Windows.Forms.Panel();
            
            //add the person to the panel
            AddPersonToPanel(ref panel1, user);

            this.flowLayoutPanel1.Controls.Add(panel1);

            //show the children
            this.flowLayoutPanel1.Controls.SetChildIndex(panel1, flowLayoutPanel1.Controls.Count);
        }


        private void AddPersonToPanel(ref Panel myPanel, User person)
        {
            Label userNameLabel = new System.Windows.Forms.Label();
            Label emailLabel = new System.Windows.Forms.Label();
            GroupBox photoGroupBox1 = new System.Windows.Forms.GroupBox();
            PictureBox photoPictureBox = new System.Windows.Forms.PictureBox();

            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1301, 751);
            this.flowLayoutPanel1.TabIndex = 17;
            /// 
            // panel1
            // 
            myPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            myPanel.Controls.Add(userNameLabel);
            myPanel.Controls.Add(emailLabel);
            myPanel.Controls.Add(photoGroupBox1);
            myPanel.Controls.Add(photoPictureBox);
            myPanel.Location = new System.Drawing.Point(3, 3);
            myPanel.Name = "panel1";
            myPanel.Size = new System.Drawing.Size(310, 377);
            myPanel.TabIndex = 19;
            myPanel.Tag = person;
     
            // 
            // label1
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(70, 33);
            userNameLabel.Name = "nameLabel";
            userNameLabel.Size = new System.Drawing.Size(93, 32);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = person.userName;
            // 
            // photoPictureBox
            // 
            photoPictureBox.BackColor = System.Drawing.Color.Silver;
            photoPictureBox.Location = new System.Drawing.Point(30, 85);
            photoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            photoPictureBox.Name = "photoPictureBox";
            photoPictureBox.Size = new System.Drawing.Size(167, 140);
            photoPictureBox.TabIndex = 1;
            photoPictureBox.TabStop = false;
            photoPictureBox.ImageLocation = person.photoPath;
            photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // groupBox1
            // 
            photoGroupBox1.Controls.Add(this.photoPictureBox);
            photoGroupBox1.Controls.Add(this.nameLabel);
            photoGroupBox1.Location = new System.Drawing.Point(28, 47);
            photoGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            photoGroupBox1.Name = "groupBox1";
            photoGroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            photoGroupBox1.Size = new System.Drawing.Size(197, 187);
            photoGroupBox1.TabIndex = 1;
            photoGroupBox1.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            emailLabel.Location = new System.Drawing.Point(22, 19);
           emailLabel.Name = "emailLabel";
           emailLabel.Size = new System.Drawing.Size(128, 35);
           emailLabel.TabIndex = 20;
           emailLabel.Text = person.email;

        }//end add person to panel

        private void HomePictureBox__Click(object sender, EventArgs e)
        {
            //open home form

        }
    }



}
