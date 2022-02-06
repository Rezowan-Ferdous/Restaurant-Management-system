using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    internal class ItemDetails
    {
        public Item ItemId { get; set; }
        public RawMaterials RawMaterialsId { get; set; }
        public string Comment { get; set; }
    }
}
