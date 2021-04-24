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


            //event handler for the photo

            //event handler for exit button
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            
            //event handler for the check box
            this.webCheckBox.Checked += new EventHandler(WebCheckBox__Checked);

            //need to add tool tip to the text boxes

            //text box event handler
            //1st box
            this.harrisonNumTextBox.KeyPress += new KeyPressEventHandler(HarrisonNumTextBox__KeyPress);
            this.fRooseveltTextBox.KeyPress += new KeyPressEventHandler(FRooseveltTextBox__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(BuchananTextBox__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(PierceTextBox__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(KennedyTextBox__KeyPress);
            //2nd row
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(McknleyTextBox__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(ReaganTextBox__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(EisenhowerTextBox__KeyPress);
            this.vanBurenTextBox.KeyPress += new KeyPressEventHandler(VanBuranTextBox__KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(WashingtonTextBox__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox__KeyPress);
            this.tRooseveltTextBox += new KeyPressEventHandler(TRooseveltTextBox__KeyPress);
            this.jeffersonTextBox += new KeyPressEventHandler(JeffersonTextBox__KeyPress);

            //hover delegate for each textbox


            //webbrower control event handler to download the html
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
            webBrowser1.Navigate("https://google.com");

            //set timer interval
            //timer tick handler
            timer1.Interval = 1000;

            timer1.Tick += new EventHandler(Timer__Tick);
            
        }

        //president event handlers
        //depending on the radio button, respective pres will appear in browser
        private void BHarrisonRadioButton__Checked(object sender, EventArgs e)
        {
            //if the harrison button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end BHarrison 

        private void FDRooseveltRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            if (this.fDRooseveltRadioButton.Checked == true)
            {
                //1. display photo
                //2. web browser will go to his wikipedia page
                //3. title of group box changes to that html
            }


        }//end FDR

        private void WJClintonRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end Clinton

        private void JBuchananRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end Buchanan

        private void FPierceRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end f Pierce

        private void GWBushRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end G Bush

        private void BObamaRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end obama

        private void JFKennedyRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end JFK

        private void WMcKinleyRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end McKinley

        private void RReaganRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end R Reagan

        private void DDEisenhowerRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end Eisenhower

        private void MVanBurenRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end VanBuren 

        private void GWashingtonRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end Washington

        private void JAdamsRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end J adams

        private void TRooseveltRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }// end t roosevelt

        private void TJeffersonRadioButton__Checked(object sender, EventArgs e)
        {
            //if the button is checked, then:
            //1. display photo
            //2. web browser will go to his wikipedia page
            //3. title of group box changes to that html

        }//end t jefferson

        private void AllRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked:
            //display all radio buttons

        }//end all checked

        private void DemocratRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked:
            //display only radio buttons with democatic pres

        }//end democratic

        private void RepublicanRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked:
            //display only republiican pres

        }//end republican 

        private void Demo_repubRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked
            //display both democrat and republican pres

        }//end demo repub

        private void FederalistRadioButton__Checked(object sender, EventArgs e)
        {
            //if checked
            //only display federalist pres

        }//end federalist

        private void HarrisonNumTextBox__KeyPress(object sender, EventArgs e)
        {
            //start the timer since the input was changed
            //check user input
            //if input == 0 
            //do nothing
            //if user input == pres number
            //correct
            //else
            //show error saying incorect until correct answer is inputed

        }//end Harrison text box

        private void FRooseveltTextBox__KeyPress(object sender, EventArgs e)
        {
            //start the timer since the input was changed
            //check user input
            //if input == 0 
            //do nothing
            //if user input == pres number
            //correct(do nothing, keep time running)
            //else
            //show error saying incorect until correct answer is inputed

        }//end Roosevelt text box

        public void ClintonTextBox__KeyPress(object sender, EventArgs e)
        {
            //start the timer since the input was changed
            //check user input
            //if input == 0 
            //do nothing
            //if user input == pres number
            //correct(do nothing, keep time running)
            //else
            //show error saying incorect until correct answer is inputed

        }//end clinton text box

        private void BuchananTextBox__KeyPress(object sender, EventArgs e)
        {
            //start the timer since the input was changed
            //check user input
            //if input == 0 
            //do nothing
            //if user input == pres number
            //correct(do nothing, keep time running)
            //else
            //show error saying incorect until correct answer is inputed

        }//end buchanan text box






        private void Timer__Tick(object sender, EventArgs e)
        {
            
        }//end timer_tick



        private void ExitButton__Click(object sender, EventArgs e)
        {
            //end the application
            Application.Exit();
        }

    }
}
