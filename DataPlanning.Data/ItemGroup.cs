using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class ItemGroup
    {
        public int Id { get; set; }
        public int ItemGroupCategoryId { get; set; }
        public int RequestId { get; set; }

        public ItemGroupCategory ItemGroupCategory { get; set; }
        public Request Request { get; set; }

        public List<ItemGroupApproval> ItemGroupApprovals { get; set; }
        public List<Order> Orders { get; set; }
        public List<RequestItem> RequestItems { get; set; }
    }
}
