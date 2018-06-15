using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class HandReceiptItem
    {
        public int Id { get; set; }
        public int HandReceiptId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        public HandReceipt HandReceipt { get; set; }
        public NsnItem NsnItem { get; set; }
    }
}
