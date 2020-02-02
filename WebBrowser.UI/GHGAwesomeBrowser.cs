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

        private void goButton_Click(object sender, EventArgs e)
        {
            // when the go button is pressed, it navigates to the url in browser.
            browser1.Navigate(addressTextBox.Text);
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // when enter is pressed on the address box, it navigates to the url in browser.
            if (e.KeyCode == Keys.Enter)
            {
                browser1.Navigate(addressTextBox.Text);
            }
        }

        private void GHGAwesomeBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
