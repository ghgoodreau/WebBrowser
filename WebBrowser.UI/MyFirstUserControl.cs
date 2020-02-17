using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class MyFirstUserControl : UserControl
    {
        // forward and back stacks
        public Stack<string> forwardLinks = new Stack<string>();
        public Stack<string> backwardLinks = new Stack<string>();

        public MyFirstUserControl()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // when the go button is pressed, it navigates to the url in browser.
            browser1.Navigate(addressTextBox.Text);

            // when the go button is pressed, it adds to history
            var historyItem = new HistoryItem();
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
            forwardLinks.Push(browser1.Url.ToString());
            browser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            // navigates forward a page
            backwardLinks.Push(browser1.Url.ToString());
            browser1.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // refreshes current page
            browser1.Refresh();
        }

        // updates address text box to display current url
        private void browser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressTextBox.Text = browser1.Url.ToString();
        }
    }
}
