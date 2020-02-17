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

        // onload event
        private void History_ManagerForm_Load(object sender, System.EventArgs e)
        {
            var items = HistoryManager.GetItems();
        }
    }
}
