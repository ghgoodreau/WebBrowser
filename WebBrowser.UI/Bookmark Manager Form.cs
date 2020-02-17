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
    public partial class Bookmark_Manager_Item : Form
    {
        public Bookmark_Manager_Item()
        {
            InitializeComponent();
        }

        private void Bookmark_Manager_Item_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} [{1}]", item.Title, item.URL));
            }
        }
    }
}
