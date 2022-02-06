using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class PurchaseRM:BaseProps
    {
        public int InvoiceId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string Comments { get; set; }
    }
}
