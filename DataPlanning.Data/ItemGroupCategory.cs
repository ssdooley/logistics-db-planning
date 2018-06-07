using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class ItemGroupCategory
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public List<ItemCategory> ItemCategories { get; set; }
        public List<ItemGroup> ItemGroups { get; set; }
    }
}
