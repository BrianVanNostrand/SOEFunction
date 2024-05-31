using SOEFunctionalityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SOEFunctionalityTest.Commands
{
    class DataGridCommands
    {
        public static List<SOEResponseModel> UpdateSelection(List<SOEResponseModel> SelectedItems,object list)
        {
            System.Collections.IList items = (System.Collections.IList)list;
            var collection = items.Cast<SOEResponseModel>();
            return collection.ToList();
        }
    }
}
