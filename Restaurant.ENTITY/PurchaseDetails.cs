using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class PurchaseDetails:BaseProps
    {
        public int PurchaseRMId { get; set; }
        public PurchaseRM PurchaseRM { get; set; }
        public int RawMaterialsId { get; set; }
        public RawMaterials RawMaterials { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

    }
}
