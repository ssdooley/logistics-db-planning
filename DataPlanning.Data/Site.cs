using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class Site
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<LogUser> LogUsers { get; set; }
        public List<NsnItem> NsnItems { get; set; }
        public List<PropertyRecord> PropertyRecords { get; set; }
        public List<Request> Requests { get; set; }
        public List<SoftwareItem> SoftwareItems { get; set; }
    }
}
