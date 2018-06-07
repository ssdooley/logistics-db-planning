using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class Approver
    {
        public int Id { get; set; }
        public int ApprovalGroupId { get; set; }
        public int UserId { get; set; }

        public ApprovalGroup ApprovalGroup { get; set; }
        public User User { get; set; }
    }
}
