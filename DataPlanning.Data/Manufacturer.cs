using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public int ItemCategoryId { get; set; }
        public string Name { get; set; }

        public ItemCategory ItemCategory { get; set; }

        public List<Item> Items { get; set; }
    }
}
