using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    internal class OrderDetails
    {
        public Order OrderId { get; set; }
        public List<Item> Itemlist { get; set; }

    }
}
