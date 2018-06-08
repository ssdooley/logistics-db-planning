using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class ItemReceipt
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public string Remarks { get; set; }
        public DateTime ReceiptDate { get; set; }

        public Item Item { get; set; }
        public User User { get; set; }
    }
}
