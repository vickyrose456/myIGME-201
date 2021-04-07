using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.Text = "MyEditor";

        }

        private void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";

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
    }
}
