using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ENTITY
{
    public class SubItem : BaseProps
    {
        [Required]
        public string ItemName { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public int MenuItemId { get; set; }

        public MenuItem  MenuItem { get; set; }

        public ICollection<RawMaterials> RawMaterialses { get; set; }

    }
}
