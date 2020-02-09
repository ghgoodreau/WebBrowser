using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// author Gregory Goodreau
// version 2/1/2020
// Web Browser Class Project 

namespace WebBrowser.UI
{
    public partial class GHGAwesomeBrowser : Form
    {
        public GHGAwesomeBrowser()
        {
            InitializeComponent();
        }

        // will display pop up about me
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! My name is Gregory Goodreau (ghg0004). I am online Auburn Student. " +
                "This is my web browser that I am incrimentally designing over the course of a semester.");
        }

        // exits the web browser
        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // loads browser
        private void GHGAwesomeBrowser_Load(object sender, EventArgs e)
        {

        }

        // creates a new tab
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage("New Tab");
            tabControl1.TabPages.Add(newTabPage);
            MyFirstUserControl newTabControl = new MyFirstUserControl();
            newTabControl.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(newTabControl);
        }

        // closes current tab
        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }
    }
}
