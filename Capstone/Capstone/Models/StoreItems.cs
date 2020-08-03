using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class StoreItems
    {
        public StoreItems()
        {

        }

        public int StoreItemsID { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
