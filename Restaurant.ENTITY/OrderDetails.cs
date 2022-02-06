using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class OrderDetails:BaseProps
    {
        public int Counter { get; set; }
        public int OrderId { get; set; }
        public Order Orders { get; set; }

        public int SubItemId { get; set; }
        public SubItem SubItems { get; set; }

    }
}
