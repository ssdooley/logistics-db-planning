using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public int ItemGroupCategoryId { get; set; }
        public string Label { get; set; }

        public ItemGroupCategory ItemGroupCategory { get; set; }

        public List<Item> Items { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
    }
}
