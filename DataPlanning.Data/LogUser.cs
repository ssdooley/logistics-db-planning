using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class LogUser
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int UserId { get; set; }

        public Site Site { get; set; }
        public User User { get; set; }
    }
}
