using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class MenuItem:BaseProps
    {
        public string MenuItemName { get; set; } 
        public string Description { get; set; }

        public ICollection<SubItem> SubItems { get; set; }
    }
}
