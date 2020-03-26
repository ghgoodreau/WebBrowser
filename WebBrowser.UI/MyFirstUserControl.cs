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

/// <summary>
/// AUTHOR GREGORY GOODREAU
/// VERSION 3/26/2020
/// WEB BROWSER
/// </summary>

namespace WebBrowser.UI
{
    public partial class MyFirstUserControl : UserControl
    {
        /////////////////////////////////////////////////
        // FORWARD AND BACKWARD STACKS FOR NAVIGATION //
        ///////////////////////////////////////////////
        public Stack<string> forwardLinks = new Stack<string>();
        public Stack<string> backwardLinks = new Stack<string>();

        public MyFirstUserControl()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////
        // NAVIGATES TO WEB PAGE IN ADDRESS BAR WHEN CLICKED //
        //////////////////////////////////////////////////////
        private void goButton_Click(object sender, EventArgs e)
        {
            // when the go button is pressed, it navigates to the url in browser.
            browser1.Navigate(addressTextBox.Text);

            // when the go button is pressed, it adds to history
            var historyItem = new HistoryItem();
            historyItem.URL = addressTextBox.Text;
            historyItem.Title = browser1.DocumentTitle;
            historyItem.Date = DateTime.Now;
            HistoryManager.AddItem(historyItem);
        }

        //////////////////////////////////////////////////////////////////
        // NAVIGATES TO WEB PAGE IN ADDRESS BAR WHEN ENTER KEY PRESSED //
        ////////////////////////////////////////////////////////////////
        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // when enter is pressed on the address box, it navigates to the url in browser.
            if (e.KeyCode == Keys.Enter)
            {
                browser1.Navigate(addressTextBox.Text);


                // when enter is pressed it adds to history
                var historyItem = new HistoryItem();
                historyItem.URL = addressTextBox.Text;
                historyItem.Title = browser1.DocumentTitle;
                historyItem.Date = DateTime.Now;
                HistoryManager.AddItem(historyItem);
            }
        }

        /////////////////////////////////////////////////////
        // NAVIGATES BACK A PAGE WHEN BACK BUTTON CLICKED //
        ///////////////////////////////////////////////////
        private void backButton_Click(object sender, EventArgs e)
        {
            // navigates back a page
            forwardLinks.Push(browser1.Url.ToString());
            browser1.GoBack();
        }

        ////////////////////////////////////////////////////////
        // NAVIGATES FORWARD A PAGE WHEN BACK BUTTON CLICKED //
        //////////////////////////////////////////////////////
        private void forwardButton_Click(object sender, EventArgs e)
        {
            // navigates forward a page
            backwardLinks.Push(browser1.Url.ToString());
            browser1.GoForward();
        }

        //////////////////////////////////////
        // REFRESHES THE PAGE WHEN CLICKED //
        ////////////////////////////////////
        private void refreshButton_Click(object sender, EventArgs e)
        {
            // refreshes current page
            browser1.Refresh();
        }

        //////////////////////////////////////////////////////
        // UPDATES ADDRESS TEXT BOX TO DISPLAY CURRENT URL //
        ////////////////////////////////////////////////////
        private void browser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressTextBox.Text = browser1.Url.ToString();
        }

        ///////////////////////////////////////////////////
        // ADDS A BOOKMARK TO THE DATABASE WHEN CLICKED //
        /////////////////////////////////////////////////
        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            var bookmarkItem = new BookmarkItem();
            bookmarkItem.URL = addressTextBox.Text;
            bookmarkItem.Title = browser1.DocumentTitle;
            BookmarkManager.AddItem(bookmarkItem);
        }

        ///////////////////////////////////////////////////
        // DISPLAYS A LOADING BAR WITH LOADING PROGRESS //
        /////////////////////////////////////////////////
        private void browser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            // progress bar values
            try
            {
                progressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                progressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex)
            {
                // empty for now
            }

            if (progressBar1.Value < e.MaximumProgress)
            {
                statusLabel.Text = "loading...";
            }
            else
            {
                statusLabel.Text = "done";
            }
        }

        /////////////////////////////////////////////////////////
        // NAGIVATES TO THE HOME PAGE WHICH IS STATICALLY SET //
        ///////////////////////////////////////////////////////
        private void homeButton_Click(object sender, EventArgs e)
        {
            browser1.Navigate("ghgoodreau.github.io");
        }
    }
}
