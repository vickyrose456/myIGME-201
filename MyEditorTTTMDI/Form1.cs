using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem__Click);
            this.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            this.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem__Click);
            this.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem__Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.testToolStripButton.Click += new EventHandler(TestToolStripButton__Click);

            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox__SelectionChanged);


            this.countdownLabel.Visible = false;
            //timer control
            this.timer.Tick += new EventHandler(Timer__Tick);


            this.Text = "MyEditor";

        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";

        }

        private void MSSansSerifToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //need fam, size and style
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }


        private void TimesNewRomanToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //need fam, size and style
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        private void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripMenuItem.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;
            }

            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }


        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //if the selected text has multiple fonts, then the font of the selected text will be null
            //fontstyle = enumerated type
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            //catch the null font
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //if its bold it will no longer make it bold
            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        //making the words italic
        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //if the selected text has multiple fonts, then the font of the selected text will be null
            //fontstyle = enumerated type
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            //catch the null font
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //if its italic it will no longer make it bold
            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            //if the selected text has multiple fonts, then the font of the selected text will be null
            //fontstyle = enumerated type
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            //catch the null font
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            //if its underlined it will no longer make it bold
            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        private void TestToolStripButton__Click(object sender, EventArgs e)
        {
            this.timer.Interval = 500;

            this.toolStripProgressBar.Value = 60;

            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = true;
            this.richTextBox.Visible = false;

            for (int i = 3; i > 0; --i)
            {
                this.countdownLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }

            this.countdownLabel.Visible = false;
            this.richTextBox.Visible = true;

            this.timer.Start();
            
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            //need to decrement the progress bar
            --this.toolStripProgressBar.Value;

            if (this.toolStripProgressBar.Value == 0)
            {
                this.timer.Stop();

                string performance = "Congratulations, you typed " + Math.Round(this.richTextBox.TextLength / 30.0, 2) + " letters per second";
                
                MessageBox.Show(performance);
            }

            
        }


        //saving delegate method
        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.FileName;
            //if opening existing file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //then a file was selected
                //we need to know the file that needs to be loaded
                //so we need the path 
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    //if its text than load plain text
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        private void OpenToolStripMenuItem__Click(object sender, EventArgs e) 
        {
            //if opening existing file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //then a file was selected
                //we need to know the file that needs to be loaded
                //so we need the path 
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    //if its text than load plain text
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }
        }

        private void CopyToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void CutToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void PasteToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            //which tool button was clicked.. deefault to null

            ToolStripButton toolStripButton = null;
            if (e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (e.ClickedItem == this.italicToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicToolStripButton;
            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            } 
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                //the color dialog was clicked
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    //set the text color to the selected color
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;

                }
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);

            }



        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;

            //if text has multiple fonts, then the selection is null
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else 
            {
                //will reset the font style
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //exit delegate method
        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
