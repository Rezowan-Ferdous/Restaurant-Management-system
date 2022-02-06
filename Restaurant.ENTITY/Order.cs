using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class Order
    {
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalBill { get; set; }
        public double Tips { get; set; }
        public double Discount { get; set; }
    }
}
