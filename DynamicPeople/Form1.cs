using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleLib;
using CourseLib;
using EditPerson;
using PeopleAppGlobals;

/*
 * Controls
 *Teacher button
 *student button
 *image list
 *split container
 *flowlayoutpanel
 *panel
 *toolstrip
 *toolstriplinklbel
 *tool strip button
 *email label
 *photo group box
 *photo pic box
 *plus image
 *minus img
 *people globals.dll
 *edit person.dll
 *
 *
 */
namespace DynamicPeople
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Globals.AddPeopleSampleData();

            this.teacherButton.Click += new EventHandler(TeacherButton__Click);
            this.studentButton.Click += new EventHandler(StudentButton__Click);

            this.panel1.Visible = false;
        }

        private void TeacherButton__Click(object sender, EventArgs e)
        {
            //clearing array of controls assoc w/ panel
            this.flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, Person> keyValuePair in Globals.people.sortedList)
            {
                if (keyValuePair.Value.GetType() == typeof(Teacher))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            teacherButton.Text = this.flowLayoutPanel1.Controls.Count.ToString();
        }
        private void StudentButton__Click(object sender, EventArgs e)
        {
            //clearing array of controls assoc w/ panel
            this.flowLayoutPanel1.Controls.Clear();

            foreach (KeyValuePair<string, Person> keyValuePair in Globals.people.sortedList)
            {
                if (keyValuePair.Value.GetType() == typeof(Student))
                {
                    AddPanel(keyValuePair.Value);
                }
            }

            studentButton.Text = this.flowLayoutPanel1.Controls.Count.ToString();
        }

        private void ToolStripButton1__Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            Panel p = (Panel)tsb.Tag;

            if (tsb.Checked)
            {
                //if checked we want button image to be the minus
                tsb.Image = global::DynamicPeople.Properties.Resources.plus;
                //panel shrink size
                p.Size = new System.Drawing.Size(189, 50);
                tsb.Checked = false;
            }
            else 
            {
                tsb.Image = global::DynamicPeople.Properties.Resources.minus;
                p.Size = new System.Drawing.Size(189, 159);
                tsb.Checked = true;
            }

            p.Refresh();

        }


        private void ToolStripLabel1(object sender, EventArgs e)
        {
            ToolStripLabel tsl = (ToolStripLabel)sender;
            Panel p = (Panel)tsl.Tag;

            //create person edit from
            PersonEditForm pef = new PersonEditForm((Person)p.Tag, this);

        }








        private void teacherButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
