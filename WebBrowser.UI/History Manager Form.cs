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

namespace WebBrowser.UI
{
    public partial class History_Manager_Form : Form
    {
        public History_Manager_Form()
        {
            InitializeComponent();
        }

        private void History_Manager_Form_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        // searches history and displays any matches
        private void histSearchButton_Click(object sender, EventArgs e)
        {
            // TODO: make case insensitive
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

        // deletes selected item from history
        private void histDeleteButton_Click(object sender, EventArgs e)
        {
            var candidate = historyListBox.SelectedIndex;
            historyListBox.Items.RemoveAt(candidate);
        }

        // clears all items from history
        private void histClearButton_Click(object sender, EventArgs e)
        {
            // clears history list
            historyListBox.Items.Clear();
        }
    }
}
