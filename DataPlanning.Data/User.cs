using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class User
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public List<Approver> Approvers { get; set; }
        public List<ItemGroupApproval> ItemGroupApprovals { get; set; }
        public List<LogUser> LogUsers { get; set; }
        public List<Order> Orders { get; set; }
        public List<PropertyCustodian> PropertyCustodians { get; set; }
        public List<Request> Requests { get; set; }
    }
}
