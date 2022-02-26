using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class Unit:BaseProps
    {
        public string? UnitName { get; set; }
        public string? Details { get; set; }

        public ICollection<RawMaterials>? RawMaterials { get; set; }
    }
}
