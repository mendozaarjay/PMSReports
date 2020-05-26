using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public static class Finder
    {
        public static string SearchResult()
        {
            var value = string.Empty;
            FinderForm frm = new FinderForm();
            frm.ShowDialog();
            value = frm.SearchResult;
            return value;
        }
    }
}
