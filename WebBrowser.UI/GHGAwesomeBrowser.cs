using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using System.Data.SqlClient;

/// <summary>
/// AUTHOR GREGORY GOODREAU
/// VERSION 3/26/2020
/// WEB BROWSER
/// </summary>

namespace WebBrowser.UI
{
    public partial class GHGAwesomeBrowser : Form
    {
        public GHGAwesomeBrowser()
        {
            InitializeComponent();
        }
        
        ///////////////////////////////////////////
        // DISPLAYS POP-UP MESSAGE BOX ABOUT ME //
        /////////////////////////////////////////
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! My name is Gregory Goodreau (ghg0004). I am online Auburn Student. " +
                "This is my web browser that I am incrimentally designing over the course of a semester.");
        }

        /////////////////////////////////////////
        // EXITS THE WEB BROWSER WHEN CLICKED //
        ///////////////////////////////////////
        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////////////////////
        // LOADS THE WEB BROWSER WHEN CLICKED //
        ///////////////////////////////////////
        private void GHGAwesomeBrowser_Load(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////
        // CREATES A NEW TAB WHEN CLICKED //
        ///////////////////////////////////
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage("New Tab");
            tabControl1.TabPages.Add(newTabPage);
            MyFirstUserControl newTabControl = new MyFirstUserControl();
            newTabControl.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(newTabControl);
        }

        //////////////////////////////////////
        // CLOSES CURRENT TAB WHEN CLICKED //
        ////////////////////////////////////
        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }
        //////////////////////////////////////
        // SHOWS HISTORY FORM WHEN CLICKED //
        ////////////////////////////////////
        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyItem = new History_Manager_Form();
            historyItem.ShowDialog();
        }
        ///////////////////////////////////////
        // SHOWS BOOKMARK FORM WHEN CLICKED //
        /////////////////////////////////////
        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkItem = new Bookmark_Manager_Form();
            bookmarkItem.ShowDialog();
        }

        private void myFirstUserControl1_Load(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////
        // CLEARS HISTORY DATABASE WHEN CLICKED //
        /////////////////////////////////////////
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.DeleteHist();
        }
    }
}
