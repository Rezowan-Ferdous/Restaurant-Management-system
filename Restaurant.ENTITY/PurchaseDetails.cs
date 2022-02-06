using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    internal class PurchaseDetails:BaseProps
    {
        public PurchaseRM PurchaseRMId { get; set; }
        public RawMaterials RawMaterialsId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

    }
}
