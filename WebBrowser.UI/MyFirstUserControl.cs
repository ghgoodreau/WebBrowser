using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MyFirstUserControl : UserControl
    {
        public MyFirstUserControl()
        {
            InitializeComponent();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            // navigates back a page
            browser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            // navigates forward a page
            browser1.GoForward();
        }
    }
}
