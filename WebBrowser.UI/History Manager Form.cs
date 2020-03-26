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
    public partial class History_Manager_Form : Form
    {
        public History_Manager_Form()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////
        // LOADS HISTORY ITEMS FROM DATABASE //
        //////////////////////////////////////
        private void History_Manager_Form_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        ////////////////////////////////////////////////
        // SEARCHES HISTORY AND DISPLAYS ANY MATCHES //
        //////////////////////////////////////////////
        private void histSearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Title.Contains(histSearchBox.Text))
                {
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        ///////////////////////////////////////
        // DELETES SEARCH ITEM FROM HISTORY //
        /////////////////////////////////////
        private void histDeleteButton_Click(object sender, EventArgs e)
        {
            // finds candidate for deletion
            string candidate = historyListBox.GetItemText(historyListBox.SelectedItem);
            // calls HistoryManager RemoveHist method which deletes the row
            HistoryManager.RemoveHist(candidate);
            // deletes the list box selected row as well.
            historyListBox.Items.RemoveAt(historyListBox.SelectedIndex);
        }

        ////////////////////////////////////
        // CLEARS ALL ITEMS FROM HISTORY //
        //////////////////////////////////
        private void histClearButton_Click(object sender, EventArgs e)
        {
            // clears history database
            HistoryManager.DeleteHist();
            // clears history list
            historyListBox.Items.Clear();
        }
    }
}
