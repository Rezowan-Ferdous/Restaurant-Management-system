using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    internal class Item
    {
        public string ItemName { get; set; }
        public MenuItem  MenuItem { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }


    }
}
