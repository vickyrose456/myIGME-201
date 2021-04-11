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
    public partial class MyEditorParent : Form
    {
        public MyEditorParent()
        {
            InitializeComponent();


            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem__Click);
            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem__Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenu__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);

            Form1 form1 = new Form1(this);
            form1.Show();

        }

        public void TileToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        public void CascadeToolStripMenu__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        public void NewToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);

            form1.Show();
        }

        public void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
