using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class HandReceipt
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int UserId { get; set; }
        public string Remarks { get; set; }
        public DateTime DateCreated { get; set; }

        public Site Site { get; set; }
        public User User { get; set; }

        public List<HandReceiptItem> HandReceiptItems { get; set; }
        public List<HandReceiptVerification> HandReceiptVerifications { get; set; }
    }
}
