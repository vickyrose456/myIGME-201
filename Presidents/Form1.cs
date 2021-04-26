using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
        int numCorrect = 0;

        public Form1()
        {
            InitializeComponent();

            //event handlers for each radio button (presidents)
            //(1st row)
            this.bHarrisonRadioButton.CheckedChanged += new EventHandler(BHarrisonRadioButton__Checked);
            this.fDRooseveltRadioButton.CheckedChanged += new EventHandler(FDRooseveltRadioButton__Checked);
            this.wJClintonRadioButton.CheckedChanged += new EventHandler(WJClintonRadioButton__Checked);
            this.jBuchananRadioButton.CheckedChanged += new EventHandler(JBuchananRadioButton__Checked);
            this.fPierceRadioButton.CheckedChanged += new EventHandler(FPierceRadioButton__Checked);
            this.gWBushRadioButton.CheckedChanged += new EventHandler(GWBushRadioButton__Checked);
            this.bObamaRadioButton.CheckedChanged += new EventHandler(BObamaRadioButton__Checked);
            this.jFKennedyRadioButton.CheckedChanged += new EventHandler(JFKennedyRadioButton__Checked);
            //2nd row)
            this.wMcKinleyRadioButton.CheckedChanged += new EventHandler(WMcKinleyRadioButton__Checked);
            this.rReaganRadioButton.CheckedChanged += new EventHandler(RReaganRadioButton__Checked);
            this.dDEisenhowerRadioButton.CheckedChanged += new EventHandler(DDEisenhowerRadioButton__Checked);
            this.mVanBurenRadioButton.CheckedChanged += new EventHandler(MVanBurenRadioButton__Checked);
            this.gWashingtonRadioButton.CheckedChanged += new EventHandler(GWashingtonRadioButton__Checked);
            this.jAdamsRadioButton.CheckedChanged += new EventHandler(JAdamsRadioButton__Checked);
            this.tRooseveltRadioButton.CheckedChanged += new EventHandler(TRooseveltRadioButton__Checked);
            this.tJeffersonRadioButton.CheckedChanged += new EventHandler(TJeffersonRadioButton__Checked);

            //event handlers for each radio button in group box filter
            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton__Checked);
            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__Checked);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__Checked);
            this.demo_repubRadioButton.CheckedChanged += new EventHandler(Demo_repubRadioButton__Checked);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__Checked);



            //event handler for exit button
            
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            
            if (numCorrect == 16)
            {
                this.exitButton.Enabled = true;
            }
            else { this.exitButton.Enabled = false;}

            //need to add tool tip to the text boxes when hovering over them


            //event handler for the photo
            //hover over the photo => the photo gets larger
             this.pictureBox.MouseHover += new EventHandler(PictureBox__MouseHover);
            this.pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            //text box event handler
            //1st box
            this.harrisonNumTextBox.KeyPress += new KeyPressEventHandler(HarrisonNumTextBox__KeyPress);
            this.fRooseveltTextBox.KeyPress += new KeyPressEventHandler(FRooseveltTextBox__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(BuchananTextBox__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(PierceTextBox__KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(BushTextBox__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(KennedyTextBox__KeyPress);
            //2nd row
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(McknleyTextBox__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(ReaganTextBox__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(EisenhowerTextBox__KeyPress);
            this.vanBurenTextBox.KeyPress += new KeyPressEventHandler(VanBuranTextBox__KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(WashingtonTextBox__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox__KeyPress);
            this.tRooseveltTextBox.KeyPress += new KeyPressEventHandler(TRooseveltTextBox__KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(JeffersonTextBox__KeyPress);

            //hover delegate for each textbox


            //webbrower control event handler to download the html
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
            //webBrowser1.Navigate("google.com");

            //set timer interval
            //timer tick handler
            timer1.Interval = 1000;
            toolStripProgressBar.Value = 100;
            timer1.Tick += new EventHandler(Timer__Tick);
            
        }
        //function to make Which # president when hovering over the textbox
        private void TextBox__MouseHover(object sender, EventArgs e)
        {
            //when hovering over the textbox
            //display Which pres #?

        }//end txt hover

        private void PictureBox__MouseHover(object sender, EventArgs e)
        {

            pictureBox.Size = new System.Drawing.Size(192, 223);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

        }//end pic hover
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox.Size = new System.Drawing.Size(162, 193);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }//end pic leave hover

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //create html element
            WebBrowser wb = (WebBrowser)sender;
            HtmlElement htmlElement;

            string htmlId = null;

            //depending on the pres button, that wiki will be displayed
            if (bHarrisonRadioButton.Checked == true)
            {
                
            }

        }//end web browser doc completed


        //president event handlers
        //depending on the radio button, respective pres will appear in browser
        private void BHarrisonRadioButton__Checked(object sender, EventArgs e)
        {
            //if the harrison button is checked, then:
            if (bHarrisonRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Benjamin_Harrison");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Benjamin_Harrison";

            }


        }//end BHarrison 
        

        private void FDRooseveltRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            if (this.fDRooseveltRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_D._Roosevelt");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Franklin_D._Roosevelt";
            }


        }//end FDR

        private void WJClintonRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            if (this.wJClintonRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Bill_Clinton");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Bill_Clinton";
            }

        }//end Clinton

        private void JBuchananRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.jBuchananRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/James_Buchanan");


                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/James_Buchanan";
            }

        }//end Buchanan

        private void FPierceRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.fPierceRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Franklin_Pierce");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Franklin_Pierce";

            }

        }//end f Pierce

        private void GWBushRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.gWBushRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_W._Bush");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/George_W._Bush";
            }

        }//end G Bush

        private void BObamaRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.bObamaRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Barack_Obama");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Barack_Obama";
            }
        }//end obama

        private void JFKennedyRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.jFKennedyRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_F._Kennedy");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/John_F._Kennedy";
            }
        }//end JFK

        private void WMcKinleyRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.wMcKinleyRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/William_McKinley");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/William_McKinley";
            }

        }//end McKinley

        private void RReaganRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.rReaganRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Ronald_Reagan");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Ronald_Reagan";
            }

        }//end R Reagan

        private void DDEisenhowerRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.dDEisenhowerRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Dwight_D._Eisenhower");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Dwight_D._Eisenhower";
            }

        }//end Eisenhower

        private void MVanBurenRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.mVanBurenRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Martin_Van_Buren");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Martin_Van_Buren";
            }

        }//end VanBuren 

        private void GWashingtonRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.gWashingtonRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/George_Washington");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/George_Washington";
            }

        }//end Washington

        private void JAdamsRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.jAdamsRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/John_Adams");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/John_Adams";
            }

        }//end J adams

        private void TRooseveltRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.tRooseveltRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Theodore_Roosevelt");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Theodore_Roosevelt";
            }
        }// end t roosevelt

        private void TJeffersonRadioButton__Checked(object sender, EventArgs e)
        {
            if (this.tJeffersonRadioButton.Checked == true)
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

                this.pictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";

                //2. web browser will go to his wikipedia page
                this.webBrowser1.Navigate("https://en.wikipedia.org/wiki/Thomas_Jefferson");

                //3. title of group box changes to that html
                this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Thomas_Jefferson";
            }

        }//end t jefferson

        private void AllRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked:
            //display all radio buttons
            if (allRadioButton.Checked == true)
            {
                this.bHarrisonRadioButton.Visible = true;
                this.fDRooseveltRadioButton.Visible = true;
                this.wJClintonRadioButton.Visible = true;
                this.jBuchananRadioButton.Visible = true;
                this.fPierceRadioButton.Visible = true;
                this.gWBushRadioButton.Visible = true;
                this.bObamaRadioButton.Visible = true;
                this.jFKennedyRadioButton.Visible = true;
                this.wMcKinleyRadioButton.Visible = true;
                this.rReaganRadioButton.Visible = true;
                this.dDEisenhowerRadioButton.Visible = true;
                this.mVanBurenRadioButton.Visible = true;
                this.gWashingtonRadioButton.Visible = true;
                this.jAdamsRadioButton.Visible = true;
                this.tRooseveltRadioButton.Visible = true;
                this.tJeffersonRadioButton.Visible = true;

                //mark ben harrison checked
                bHarrisonRadioButton.Checked = true;
            }
            else { }

        }//end all checked

        private void DemocratRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked:
            if (democratRadioButton.Checked == true)
            {
                //display only radio buttons with democatic pres
                //set non demo pres to false
                this.bHarrisonRadioButton.Visible = false;
                this.fDRooseveltRadioButton.Visible = true;
                this.wJClintonRadioButton.Visible = true;
                this.jBuchananRadioButton.Visible = true;
                this.fPierceRadioButton.Visible = true;
                this.gWBushRadioButton.Visible = false;
                this.bObamaRadioButton.Visible = true;
                this.jFKennedyRadioButton.Visible = true;
                this.wMcKinleyRadioButton.Visible = false;
                this.rReaganRadioButton.Visible = false;
                this.dDEisenhowerRadioButton.Visible = false;
                this.mVanBurenRadioButton.Visible = true;
                this.gWashingtonRadioButton.Visible = false;
                this.jAdamsRadioButton.Visible = false;
                this.tRooseveltRadioButton.Visible = false;
                this.tJeffersonRadioButton.Visible = false;

                this.fDRooseveltRadioButton.Checked = true;
            }
            
        }//end democratic

        private void RepublicanRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked:
            if (republicanRadioButton.Checked == true)
            {
                //display only republiican pres
                this.bHarrisonRadioButton.Visible = true;
                this.fDRooseveltRadioButton.Visible = false;
                this.wJClintonRadioButton.Visible = false;
                this.jBuchananRadioButton.Visible = false;
                this.fPierceRadioButton.Visible = false;
                this.gWBushRadioButton.Visible = true;
                this.bObamaRadioButton.Visible = false;
                this.jFKennedyRadioButton.Visible = false;
                this.wMcKinleyRadioButton.Visible = true;
                this.rReaganRadioButton.Visible = true;
                this.dDEisenhowerRadioButton.Visible = true;
                this.mVanBurenRadioButton.Visible = false;
                this.gWashingtonRadioButton.Visible = false;
                this.jAdamsRadioButton.Visible = false;
                this.tRooseveltRadioButton.Visible = true;
                this.tJeffersonRadioButton.Visible = false;

                //mark ben harrison checked
                bHarrisonRadioButton.Checked = true;
            }
            
        }//end republican 

        private void Demo_repubRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked
            if (demo_repubRadioButton.Checked == true)
            {
                //display democrat- republican pres
                this.bHarrisonRadioButton.Visible = false;
                this.fDRooseveltRadioButton.Visible = false;
                this.wJClintonRadioButton.Visible = false;
                this.jBuchananRadioButton.Visible = false;
                this.fPierceRadioButton.Visible = false;
                this.gWBushRadioButton.Visible = false;
                this.bObamaRadioButton.Visible = false;
                this.jFKennedyRadioButton.Visible = false;
                this.wMcKinleyRadioButton.Visible = false;
                this.rReaganRadioButton.Visible = false;
                this.dDEisenhowerRadioButton.Visible = false;
                this.mVanBurenRadioButton.Visible = false;
                this.gWashingtonRadioButton.Visible = false;
                this.jAdamsRadioButton.Visible = false;
                this.tRooseveltRadioButton.Visible = false;
                this.tJeffersonRadioButton.Visible = true;


                //set t jeff button to checked
                tJeffersonRadioButton.Checked = true;
            }

        }//end demo repub

        private void FederalistRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked
            if (federalistRadioButton.Checked == true)
            {
                //only display federalist pres
                this.bHarrisonRadioButton.Visible = false;
                this.fDRooseveltRadioButton.Visible = false;
                this.wJClintonRadioButton.Visible = false;
                this.jBuchananRadioButton.Visible = false;
                this.fPierceRadioButton.Visible = false;
                this.gWBushRadioButton.Visible = false;
                this.bObamaRadioButton.Visible = false;
                this.jFKennedyRadioButton.Visible = false;
                this.wMcKinleyRadioButton.Visible = false;
                this.rReaganRadioButton.Visible = false;
                this.dDEisenhowerRadioButton.Visible = false;
                this.mVanBurenRadioButton.Visible = false;
                this.gWashingtonRadioButton.Visible = true;
                this.jAdamsRadioButton.Visible = true;
                this.tRooseveltRadioButton.Visible = false;
                this.tJeffersonRadioButton.Visible = false;

                //g washington is checked
                this.gWashingtonRadioButton.Checked = true;
            }

        }//end federalist

        private void HarrisonNumTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "23")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//end Harrison text box

        private void FRooseveltTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "32")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//end Roosevelt text box

        public void ClintonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "42")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }

        }//end clinton text box

        private void BuchananTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "15")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }

        }//end buchanan text box

        public void PierceTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "14")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//end Pierce textbox

        private void BushTextBox__KeyPress(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "44")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }

        }

        private void ObamaTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "44")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//obama text box

        private void KennedyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "35")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//kennedy text box

        private void McknleyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "25")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//McKinley text box

        private void ReaganTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "40")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//reagan txt box

        private void EisenhowerTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "34")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//end eisenhower txt box

        private void VanBuranTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "8")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//end vanburan txt box

        private void AdamsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "2")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//adams txt box

        private void WashingtonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "1")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//end washington txt box

        private void TRooseveltTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "26")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;

            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }

        }//end t roosevelt txt box

        private void JeffersonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //start the timer(if not started already) since the input was changed
            if (toolStripProgressBar.Value == 100)
            {
                timer1.Start();
            }
            else { }

            //check user input
            //if input == 0 
            if (tb.Text != "3")
            {
                this.errorProvider1.SetError(tb, "That is the wrong number");
                tb.Tag = true;
                
            }
            else
            {
                this.errorProvider1.SetError(tb, null);
                tb.Tag = true;
                numCorrect++;
            }


        }//jefferson txt box






        private void Timer__Tick(object sender, EventArgs e)
        {
            toolStripProgressBar.Value--;
            if (toolStripProgressBar.Value == 0)
            {
                //set all text boxes to 0
                this.harrisonNumTextBox.Text = "0";
                this.fRooseveltTextBox.Text = "0";
                this.clintonTextBox.Text = "0";
                this.buchananTextBox.Text = "0";
                this.pierceTextBox.Text = "0";
                this.bushTextBox.Text = "0";
                this.obamaTextBox.Text = "0";
                this.kennedyTextBox.Text = "0";
                this.mckinleyTextBox.Text = "0";
                this.reaganTextBox.Text = "0";
                this.eisenhowerTextBox.Text = "0";
                this.vanBurenTextBox.Text = "0";
                this.washingtonTextBox.Text = "0";
                this.adamsTextBox.Text = "0";
                this.tRooseveltTextBox.Text = "0";
                this.jeffersonTextBox.Text = "0";
                //none correct
                numCorrect = 0;
                //stop the timer
                timer1.Stop();

            }
        }//end timer_tick



        private void ExitButton__Click(object sender, EventArgs e)
        {
            //end the application
            Application.Exit();
        }

    }
}
