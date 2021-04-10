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
using PeopleAppGlobals;

namespace EditPerson
{
    public partial class PersonEditForm : Form
    {
        public Person formPerson;
        

        public PersonEditForm( Person person, Form parentForm )
        {
            //////////////////////////////////////////////////////////////////
            /// THIS MUST BE THE FIRST LINE OF YOUR FORM CLASS CONSTRUCTOR ///
            ////////////////////////////////////////////////////////////////// 
            InitializeComponent();

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }


            // this is the constructor of our PersonEditForm class derived from the Form parent class
            // our class has the following objects added to it:
            //    this.typeLabel : Label control
            //    this.typeComboBox : ComboBox control

            //    this.nameLabel : Label control
            //    this.nameText : TextBox control

            //    this.emailLabel : Label control
            //    this.emailText : TextBox control

            //    this.ageLabel : Label control
            //    this.ageText : TextBox control

            //    this.licLabel : Label control
            //    this.licText : TextBox control

            //    this.gpaLabel : Label control
            //    this.gpaText : TextBox control

            //    this.specialtyLabel : Label control
            //    this.specText : TextBox control

            //    this.cancelButton : Button control
            //    this.okButton : Button control

            //    this.errorProvider : ErrorProvider control

            // default the OK button to be disabled
            // and only enable it if all text fields are valid
            this.okButton.Enabled = false;

            // most Form controls have a Tag field which is a System.Object type
            // and can be used to store any property
            // loop through all of the controls on the form
            //foreach ( Control control in this.Controls )

            // because we moved the controls to the detailsTabPage,
            // we need to access them via the detailsTabPage Control
            foreach (Control control in this.detailsTabPage.Controls)
            {
                // we will use the Tag field to indicate if the field is valid or not
                // initialize Tag to false to indicate invalid
                control.Tag = false;
            }

            if ( parentForm != null )
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }

            this.formPerson = person;

            // the following excerpts are from "Windows Forms Controls" on myCourses 
            // to add Validating and TextChanged event handlers to the TextBox Controls

            /*********************************************************************************** 
            Validating Event
            Occurs when the object is leaving scope (ie. tabbing out of the field or the user clicked another field or button)
            Accepts the event handler CancelEventHandler() because the primary purpose of Validating is to determine whether 
            this event should cause the focus to leave the current control and enter the next control 
            (if CausesValidation == True for the next control).  If the validation fails, then the navigation event is 
            cancelled and the current control stays in focus.

            Example for adding the delegate method:
                this.objectName.Validating += new CancelEventHandler(this.ObjectName__Validating);

            The CancelEventHandler() delegate method must accept the following parameters:
                private void ObjectName__Validating(object sender, CancelEventArgs e)
            By convention, the delegate methods are named:
                ObjectName_EventName()

            Important Fields in sender (TextBox)
                TextBox tb = (TextBox)sender;
                tb.Text: validate for certain contents before allowing user to exit the field

            Important Fields in CancelEventArgs
                e.Cancel: a boolean to indicate whether the event should be cancelled or not.  If set to true, then the current TextBox will stay in focus.
            ************************************************************************************/

            // we want the same delegate function to be called for the following 5 fields
            // TextBoxEmpty__Validating() is defined below
            this.nameText.Validating += new CancelEventHandler(TextBoxEmpty__Validating);
            this.emailText.Validating += new CancelEventHandler(TextBoxEmpty__Validating);
            this.ageText.Validating += new CancelEventHandler(TextBoxEmpty__Validating);
            this.gpaText.Validating += new CancelEventHandler(TextBoxEmpty__Validating);
            this.specText.Validating += new CancelEventHandler(TextBoxEmpty__Validating);
            this.licText.Validating += new CancelEventHandler(TextBoxEmpty__Validating);

            /*********************************************************************************** 
            TextChanged
            Occurs when the contents of Text changes (ie. TextBox.Text)
            Accepts the empty EventHandler() delegate because the event is limited to only the current control.
            
            Example for adding the delegate method:
                    this.objectName.TextChanged += new EventHandler(this.ObjectName__TextChanged);
            
            The EventHandler delegate method must have the following signature:
                private void ObjectName__TextChanged(object sender, EventArgs e)
            
            Important Fields in sender
                TextBox tb = (TextBox)sender;
                tb.Text: the current text in the TextBox
            
            Important Fields in EventArgs
                None.
            ************************************************************************************/
            this.nameText.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
            this.emailText.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
            this.ageText.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
            this.gpaText.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
            this.specText.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);
            this.licText.TextChanged += new EventHandler(TextBoxEmpty__TextChanged);

            /*
            KeyPress Event for TextBox fields
            Occurs when the user presses a key sequence which generates a character(shift + A for example) within the control
                     Accepts the KeyPressEventHandler() delegate, whose method must have the following signature:
                        private void ObjectName__KeyPress(object sender, KeyPressEventArgs e)
            
            Example for adding the delegate method:
                    this.objectName.KeyPress += new KeyPressEventHandler(this.ObjectName__KeyPress);
            
            Important Fields in sender:
                TextBox tb = (TextBox)sender;
                tb.Text: the current text in the TextBox
            
            Important Fields in KeyPressEventArgs
                e.KeyChar: gets or sets the character just pressed allowing you to change, suppress or pass - through each character
                e.Handled: a boolean to indicate whether the delegate's method "handled" the keypress.  If it is set to true, then .NET will not process the keypress (ie. the keyboard buffer will be cleared).
            */

            this.ageText.KeyPress += new KeyPressEventHandler(TextNum__KeyPress);
            this.licText.KeyPress += new KeyPressEventHandler(TextNum__KeyPress);
            this.gpaText.KeyPress += new KeyPressEventHandler(TextNum__KeyPress);


            /*
            SelectedIndexChanged Event for ComboBox Controls
            Occurs when the user changes the ComboBox value
            Accepts the empty EventHandler() delegate because the event is limited to only the current control.
            
            Example for adding the delegate method:
                    this.objectName.SelectedIndexChanged += new EventHandler(this.ObjectName__SelectedIndexChanged);
            
            The EventHandler delegate method must have the following signature:
                private void ObjectName__SelectedIndexChanged(object sender, EventArgs e)
            
            Important Fields in sender
                ComboBox cb = (ComboBox) sender;
                    cb.SelectedIndex: the 0-based index of the selected item
                    cb.SelectedItem: the string of the display value of the selected item
            
            Important Fields in EventArgs
                None.
            */
            this.typeComboBox.SelectedIndexChanged += new EventHandler(TypeComboBox__SelectedIndexChanged);

            this.cancelButton.Click += new EventHandler(CancelButton__Click);
            this.okButton.Click += new EventHandler(OkButton__Click);

            // add the event handler to the class radio buttons
            this.froshRadioButton.CheckedChanged += new EventHandler(this.ClassRadioButton__CheckedChanged);
            this.sophRadioButton.CheckedChanged += new EventHandler(this.ClassRadioButton__CheckedChanged);
            this.juniorRadioButton.CheckedChanged += new EventHandler(this.ClassRadioButton__CheckedChanged);
            this.seniorRadioButton.CheckedChanged += new EventHandler(this.ClassRadioButton__CheckedChanged);

            this.birthDateTimePicker.ValueChanged += new EventHandler(BirthDateTimePicker__ValueChanged);

            this.photoPictureBox.Click += new EventHandler(PhotoPictureBox__Click);

            this.editPersonTabControl.SelectedIndexChanged += new EventHandler(EditPersonTabControl__SelectedIndexChanged);

            this.homepageWebBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(HomepageWebBrowser__DocumentCompleted);


            this.nameText.Text = person.name;
            this.emailText.Text = person.email;
            this.ageText.Text = person.age.ToString();
            this.licText.Text = person.LicenseId.ToString();
            this.homepageTextBox.Text = person.homePageURL;

            this.birthDateTimePicker.Value = this.birthDateTimePicker.MinDate;
            this.photoPictureBox.ImageLocation = person.photoPath;

            // if a new person being added
            if ( person.name == null )
            {
                // default to them
                this.themRadioButton.Checked = true;
            }
            else
            {
                switch (person.eGender)
                {
                    case genderPronoun.her:
                        this.herRadioButton.Checked = true;
                        break;

                    case genderPronoun.him:
                        this.himRadioButton.Checked = true;
                        break;

                    case genderPronoun.them:
                        this.themRadioButton.Checked = true;
                        break;
                }

                if ( person.dateOfBirth > this.birthDateTimePicker.MinDate )
                {
                    this.birthDateTimePicker.Value = person.dateOfBirth;
                }
            }
        
            

            // this if statement will always be false because person will only be Student and Teacher objects
            // if( person.GetType() == typeof(Person))
            // but this statement will be true because the Student or Teacher object inherits from Person
            // if( person is Person )
            // the "is" operator checks for inheritance between the object and the class/interface

            //if( person.GetType() == typeof(Student))
            if( person is Student student)
            {
                this.typeComboBox.SelectedIndex = 0;
                //Student student = (Student)person;
                this.gpaText.Text = student.gpa.ToString();


                // if a new student was added
                if( person.name == null )
                {
                    // default class year to senior
                    this.seniorRadioButton.Checked = true;
                }
                else
                {
                    switch (student.eCollegeYear)
                    {
                        case collegeYear.freshman:
                            this.froshRadioButton.Checked = true;
                            break;

                        case collegeYear.sophomore:
                            this.sophRadioButton.Checked = true;
                            break;

                        case collegeYear.junior:
                            this.juniorRadioButton.Checked = true;
                            break;

                        case collegeYear.senior:
                        default:
                            this.seniorRadioButton.Checked = true;
                            break;
                    }
                }
            }
            else
            {
                this.typeComboBox.SelectedIndex = 1;
                Teacher teacher = (Teacher)person;
                this.specText.Text = teacher.specialty;
            }


            // show this form as non-modal
            this.Show();

            // show this form as modal
            //this.ShowDialog();
        }

        private void HomepageWebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e )
        {
            WebBrowser wb = (WebBrowser)sender;

            if( wb.Document.Title == "DOM-3")
            {
                HtmlElement htmlElement;
                HtmlElementCollection htmlElementCollection;

                htmlElement = wb.Document.Body;
                htmlElement.Style += "font-family: sans-serif; color: #a000a0;";

                htmlElementCollection = wb.Document.GetElementsByTagName("h1");

                htmlElement = htmlElementCollection[0];

                htmlElement.InnerText = "My Kitten Page";

                htmlElement.MouseOver += new HtmlElementEventHandler(Example_H1__MouseOver);

                htmlElementCollection = wb.Document.GetElementsByTagName("h2");

                htmlElementCollection[0].InnerText = "Meow!";

                htmlElementCollection[1].InnerHtml = "<a href='http://www.kittens.com'>Kitties!</a>";

                htmlElementCollection[2].InnerText = "";

                htmlElement = wb.Document.GetElementById("lastParagraph");

                HtmlElement htmlElement1 = wb.Document.CreateElement("img");

                htmlElement1.SetAttribute("src", "https://en.bcdn.biz/Images/2018/6/12/27565ee3-ffc0-4a4d-af63-ce8731b65f26.jpg");

                htmlElement1.SetAttribute("title", "awwwww");

                htmlElement1.Click += new HtmlElementEventHandler(Example_IMG__Click);

                htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, htmlElement1);

                htmlElement1 = wb.Document.CreateElement("footer");

                htmlElement1.InnerHtml = "&copy;2019 <a href='http://www.nerdtherapy.org'>D.Schuh</a>";

                wb.Document.Body.AppendChild(htmlElement1);
            }
        }

        public void Example_H1__MouseOver(object sender, HtmlElementEventArgs e)
        {
            HtmlElement htmlElement = (HtmlElement)sender;
            HtmlElementCollection htmlElementCollection;

            if( htmlElement.InnerText.ToLower().Contains("kitten"))
            {
                htmlElement.InnerText = "My Puppy Page";

                htmlElementCollection = this.homepageWebBrowser.Document.GetElementsByTagName("h2");
                htmlElementCollection[0].InnerText = "Woof!";
                htmlElementCollection[1].InnerHtml = "<a href='http://www.puppies.com'>Puppies!</a>";

                htmlElementCollection = this.homepageWebBrowser.Document.GetElementsByTagName("img");
                htmlElementCollection[0].SetAttribute("src", "https://www.allthingsdogs.com/wp-content/uploads/2019/05/Cute-Puppy-Names.jpg");
            }
            else
            {
                htmlElement.InnerText = "My Kitten Page";

                htmlElementCollection = this.homepageWebBrowser.Document.GetElementsByTagName("h2");
                htmlElementCollection[0].InnerText = "Meow!";
                htmlElementCollection[1].InnerHtml = "<a href='http://www.kittens.com'>Kittens!</a>";

                htmlElementCollection = this.homepageWebBrowser.Document.GetElementsByTagName("img");
                htmlElementCollection[0].SetAttribute("src", "https://en.bcdn.biz/Images/2018/6/12/27565ee3-ffc0-4a4d-af63-ce8731b65f26.jpg");
            }
        }

        public void Example_IMG__Click(object sender, HtmlElementEventArgs e)
        {
            // If the <img> element is clicked, then Navigate() this.homepageWebBrowser to "http://m.youtube.com/watch?v=oHg5SJYRHA0"
            this.homepageWebBrowser.Navigate("http://m.youtube.com/watch?v=oHg5SJYRHA0");
        }

        private void EditPersonTabControl__SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;

            if( tc.SelectedTab == this.homepageTabPage)
            {
                this.AcceptButton = null;
                this.CancelButton = null;

                homepageWebBrowser.Navigate(this.homepageTextBox.Text);
            }
            else if(tc.SelectedTab == this.coursesTabPage)
            {
                this.AcceptButton = null;
                this.CancelButton = null;

            }
            else if(tc.SelectedTab == this.scheduleTabPage)
            {
                this.AcceptButton = null;
                this.CancelButton = null;

            }
            else if(tc.SelectedTab == this.detailsTabPage)
            {
                this.AcceptButton = this.okButton;
                this.CancelButton = this.cancelButton;

            }
        }

        private void ClassRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            // if the radio button is checked
            if (rb.Checked)
            {
                if (rb == this.froshRadioButton)
                {
                    classOfLabel.Text = "Class of 2024";
                }

                if (rb == this.sophRadioButton)
                {
                    classOfLabel.Text = "Class of 2023";
                }

                if (rb == this.juniorRadioButton)
                {
                    classOfLabel.Text = "Class of 2022";
                }

                if (rb == this.seniorRadioButton)
                {
                    classOfLabel.Text = "Class of 2021";
                }
            }
        }


        private void PhotoPictureBox__Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                pb.ImageLocation = openFileDialog.FileName;
            }
        }


        private void BirthDateTimePicker__ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if( dtp.Value == dtp.MinDate )
            {
                dtp.CustomFormat = " ";
            }
            else
            {
                dtp.CustomFormat = "MMM d, yyyy";
            }
        }

        private void OkButton__Click(object sender, EventArgs e)
        {
            Student student = null;
            Teacher teacher = null;
            Person person = null;

            Globals.people.Remove(this.formPerson.email);

            if( this.typeComboBox.SelectedIndex == 0 )
            {
                student = new Student();
                person = student;
            }
            else
            {
                teacher = new Teacher();
                person = teacher;
            }

            person.name = this.nameText.Text;
            person.email = this.emailText.Text;
            person.age = Convert.ToInt32(this.ageText.Text);
            person.LicenseId = Convert.ToInt32(this.licText.Text);
            person.homePageURL = this.homepageTextBox.Text;
            person.dateOfBirth = this.birthDateTimePicker.Value;
            person.photoPath = this.photoPictureBox.ImageLocation;

            if (this.herRadioButton.Checked)
            {
                person.eGender = genderPronoun.her;
            }

            if (this.himRadioButton.Checked)
            {
                person.eGender = genderPronoun.him;
            }

            if (this.themRadioButton.Checked)
            {
                person.eGender = genderPronoun.them;
            }

            // if( person is Student )
            if ( person.GetType() == typeof(Student))
            {
                student.gpa = Convert.ToDouble(this.gpaText.Text);

                if (this.froshRadioButton.Checked)
                {
                    student.eCollegeYear = collegeYear.freshman;
                }

                if (this.sophRadioButton.Checked)
                {
                    student.eCollegeYear = collegeYear.sophomore;
                }

                if (this.juniorRadioButton.Checked)
                {
                    student.eCollegeYear = collegeYear.junior;
                }

                if (this.seniorRadioButton.Checked)
                {
                    student.eCollegeYear = collegeYear.senior;
                }
            }
            else
            {
                teacher.specialty = specText.Text;
            }

            Globals.people[person.email] = person;

            if( this.Owner != null )
            {
                this.Owner.Enabled = true;

                this.Owner.Focus();

                IListView iListView = (IListView)this.Owner;
                iListView.PaintListView(person.email);
            }

            this.Close();
            this.Dispose();
        }

        private void TypeComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            // Student == 0
            if( cb.SelectedIndex == 0)
            {
                this.specialtyLabel.Visible = false;
                this.specText.Visible = false;

                this.gpaLabel.Visible = true;
                this.gpaText.Visible = true;

                // set specialty field as being valid
                this.specText.Tag = true;

                this.gpaText.Tag = (this.gpaText.Text.Length > 0);

                // college year group box should be visible for Student
                this.classGroupBox.Visible = true;
            }
            else
            {
                // else Teacher is selected
                this.specialtyLabel.Visible = true;
                this.specText.Visible = true;

                this.gpaLabel.Visible = false;
                this.gpaText.Visible = false;

                // set gpa field as being valid
                this.gpaText.Tag = true;

                this.specText.Tag = (this.specText.Text.Length > 0);

                // college year group box should not be visible for Teacher
                this.classGroupBox.Visible = false;
            }

            ValidateAll();
        }


        private void TextNum__KeyPress(object sender, KeyPressEventArgs e )
        {
            // A key was pressed in the associated number field
            // only allow digits or a single '.' for the gpa field
            TextBox tb = (TextBox)sender;

            // e.KeyChar contains the character that was pressed
            if( Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {
                // .NET should handle the keypress and add it to the textbox
                e.Handled = false;
            }
            else
            {
                // assume that the keystroke should not be passed on to .NET
                e.Handled = true;

                if( tb == this.gpaText )
                {
                    if( e.KeyChar == '.' && !tb.Text.Contains("."))
                    {
                        e.Handled = false;
                    }
                }
            }

            ValidateAll();
        }

        private void TextBoxEmpty__TextChanged(object textField, EventArgs e)
        {
            TextBox tb = (TextBox)textField;

            if( tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void ValidateAll()
        {
            this.okButton.Enabled =
                (bool)this.nameText.Tag &&
                (bool)this.emailText.Tag &&
                (bool)this.ageText.Tag &&
                (bool)this.specText.Tag &&
                (bool)this.gpaText.Tag &&
                (bool)this.licText.Tag;
        }

        private void CancelButton__Click(object sender, EventArgs e )
        {
            if( this.Owner != null )
            {
                // enable the parent
                this.Owner.Enabled = true;

                // and set it into focus to process mouse and keyboard events
                this.Owner.Focus();
            }

            // close this form
            this.Close();
            this.Dispose();
        }

        private void TextBoxEmpty__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if( tb.Text.Length == 0)
            {
                // show error
                this.errorProvider.SetError(tb, "This field cannot be empty.");

                // cancel moving to the next field
                e.Cancel = true;

                // invalidate the control
                tb.Tag = false;
            }
            else
            {
                // else there is data in the field
                // clear the error
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;

                // set the control to being valid
                tb.Tag = true;
            }

            ValidateAll();
        }
    }
}
