using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIFFinder
{
    public partial class GIFFinder : System.Windows.Forms.Form
    {
        SearchForm searchForm;
        public GIFFinder()
        {
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

            searchForm = new SearchForm();
            timer.Interval = 100;
            timer.Tick += new EventHandler(Timer__Tick);

            webBrowser.Navigate("https://people.rit.edu/dxsigm/gif-finder.html");

            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem__Click);
            this.newSearchToolStripMenuItem.Click += new EventHandler(NewSearchToolStripMenuItem__Click);
        }
        private void TileToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CascadeToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }
        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void NewSearchToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.searchForm.ShowDialog();

            if (searchForm.response == "OK")
            {
                HtmlElement htmlElem;

                //modfifying theDOM
                htmlElem = webBrowser.Document.GetElementById("searchTerm");

                htmlElem.SetAttribute("value", searchForm.searchTerms);

                htmlElem = webBrowser.Document.GetElementById("limit");

                htmlElem.SetAttribute("value", Convert.ToString(searchForm.maxItems));

                webBrowser.Document.InvokeScript("searchButtonClicked");
                timer.Start();
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            timer.Stop();

            HtmlElement htmlElem = webBrowser.Document.GetElementById("lastelement");

            if (htmlElem != null)
            {
                //if exists, get array element of imgs
                HtmlElementCollection htmlElementCollection;
                htmlElementCollection = webBrowser.Document.GetElementsByTagName("img");
                foreach (HtmlElement htmlElement1 in htmlElementCollection)
                {
                    
                }
            }
        }

    }
}
