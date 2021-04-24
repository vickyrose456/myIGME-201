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
            this.bHarrisonRadioButton.Checked += new EventHandler(BHarrisonRadioButton__Checked);
            this.fDRooseveltRadioButton.Checked += new EventHandler(FDRooseveltRadioButton__Checked);
            this.wJClintonRadioButton.Checked += new EventHandler(WJClintonRadioButton__Checked);
            this.jBuchananRadioButton.Checked += new EventHandler(JBuchananRadioButton__Checked);
            this.fPierceRadioButton.Checked += new EventHandler(FPierceRadioButton__Checked);
            this.gWBushRadioButton.Checked += new EventHandler(GWBushRadioButton__Checked);
            this.bObamaRadioButton.Checked += new EventHandler(BObamaRadioButton__Checked);
            this.jFKennedyRadioButton.Checked += new EventHandler(JFKennedyRadioButton__Checked);
            //2nd row)
            this.wMcKinleyRadioButton.Checked += new EventHandler(WMcKinleyRadioButton__Checked);
            this.rReaganRadioButton.Checked += new EventHandler(RReaganRadioButton__Checked);
            this.dDEisenhowerRadioButton.Checked += new EventHandler(DDEisenhowerRadioButton__Checked);
            this.mVanBurenRadioButton.Checked += new EventHandler(mVanBurenRadioButton__Checked);
            this.gWashingtonRadioButton.Checked += new EventHandler(GWashingtonRadioButton__Checked);
            this.jAdamsRadioButton.Checked += new EventHandler(JAdamsRadioButton__Checked);
            this.tRooseveltRadioButton.Checked += new EventHandler(TRooseveltRadioButton__Checked);
            this.tJeffersonRadioButton.Checked += new EventHandler(TJeffersonRadioButton__Checked);

            //event handlers for each radio button in group box filter
            this.allRadioButton.Checked += new EventHandler(AllRadioButton__Checked);
            this.democratRadioButton.Checked += new EventHandler(DemocratRadioButton__Checked);
            this.republicanRadioButton.Checked += new EventHandler(RepublicanRadioButton__Checked);
            this.demo_repubRadioButton.Checked += new EventHandler(Demo_repubRadioButton__Checked);
            this.federalistRadioButton.Checked += new EventHandler(FederalistRadioButton__Checked);


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
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(Clinton__KeyPress);
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


            //webbrower control event handler to download the html

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
        
        }
    }
}
