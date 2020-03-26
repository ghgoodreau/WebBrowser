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

/// <summary>
/// AUTHOR GREGORY GOODREAU
/// VERSION 3/26/2020
/// WEB BROWSER
/// </summary>

namespace WebBrowser.UI
{
    public partial class Bookmark_Manager_Form : Form
    {
        public Bookmark_Manager_Form()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////
        // LOADS BOOKMARK TABLE FROM DATABASE //
        ///////////////////////////////////////
        private void Bookmark_Manager_Item_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.URL, item.Title));
            }
        }
        ////////////////////////////////////////////////
        // SEARCHES FOR BOOKMARK ITEM BASED ON TITLE //
        //////////////////////////////////////////////
        private void bookSearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.URL.Contains(bookSearchTextBox.Text))
                {
                    bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.URL, item.Title));
                }
            }
        }

        /////////////////////////////////////////////
        // DELETES SELECTED BOOKMARK WHEN CLICKED //
        ///////////////////////////////////////////
        private void bookDeleteButton_Click(object sender, EventArgs e)
        {
            string candidate = bookmarkListBox.GetItemText(bookmarkListBox.SelectedItem);
            BookmarkManager.DeleteBook(candidate);
            bookmarkListBox.Items.RemoveAt(bookmarkListBox.SelectedIndex);
        }
    }
}
