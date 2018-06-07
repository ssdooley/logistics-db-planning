using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class Priority
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public List<Request> Requests { get; set; }
    }
}
