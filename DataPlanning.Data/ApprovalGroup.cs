using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class ApprovalGroup
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public bool IsLocal { get; set; }
        public bool IsCommander { get; set; }

        public List<Approver> Approvers { get; set; }
        public List<ItemGroupApproval> ItemGroupApprovals { get; set; }
    }
}
