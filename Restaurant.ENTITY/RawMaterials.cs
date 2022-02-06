using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class RawMaterials : BaseProps
    {
        public string RawMaterialName { get; set; }
        public double UnitPrice { get; set; }
        public string Details { get; set; }

        public ICollection<SubItem> SubItems { get; set; }
    }
}
