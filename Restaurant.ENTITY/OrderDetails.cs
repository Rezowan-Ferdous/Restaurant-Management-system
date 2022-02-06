using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    internal class OrderDetails:BaseProps
    {
        public Order OrderId { get; set; }

        public ICollection<SubItem> SubItems { get; set; }

    }
}
