using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

/// <summary>
/// AUTHOR GREGORY GOODREAU
/// VERSION 3/26/2020
/// WEB BROWSER
/// </summary>

namespace WebBrowser.Logic
{
    //////////////////////////////////////////////
    // METHODS THAT DRIVE THE BOOKMARK CLASSES //
    ////////////////////////////////////////////
    public class BookmarkManager
    {
        //////////////////////////
        // ADDS BOOKMARK ITEMS //
        ////////////////////////
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.Title, item.URL);
        }

        //////////////////////////
        // GETS BOOKMARK ITEMS //
        ////////////////////////
        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();
            
            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        /////////////////////////////
        // DELETES BOOKMARK ITEMS //
        ///////////////////////////
        public static void DeleteBook(string candidate)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string rowChecker = string.Format(string.Format("{0} ({1})", row.URL, row.Title));

                if (rowChecker == candidate)
                {
                    adapter.Delete(row.Id, row.Title);
                }
            }
        }
    }
}
