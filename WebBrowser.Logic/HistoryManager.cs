using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

/// <summary>
/// AUTHOR GREGORY GOODREAU
/// VERSION 3/26/2020
/// WEB BROWSER
/// </summary>

namespace WebBrowser.Logic
{
    /////////////////////////////////////////////
    // METHODS THAT DRIVE THE HISTORY CLASSES //
    ///////////////////////////////////////////
    public class HistoryManager
    {
        ////////////////////////////////////
        // ADDS HISTORY ITEM TO DATABASE //
        //////////////////////////////////
        public static void AddItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        /////////////////////////
        // GETS HISTORY ITEMS //
        ///////////////////////
        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        ////////////////////////////
        // DELETES HISTORY ITEMS //
        //////////////////////////
        public static void DeleteHist()
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date);
            }
        }

        //////////////////////////////////////
        // REMOVES A SPECIFIC HISTORY ITEM //
        ////////////////////////////////////
        public static void RemoveHist(string candidate)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                string rowChecker = string.Format(string.Format("[{0}] {1} ({2})", row.Date, row.Title, row.URL));

                if (rowChecker == candidate)
                {
                    adapter.Delete(row.Id, row.URL, row.Title, row.Date);
                }
            }
        }
    }
}
