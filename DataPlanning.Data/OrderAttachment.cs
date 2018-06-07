using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class OrderAttachment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string File { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }
        public DateTime DateUploaded { get; set; }

        public Order Order { get; set; }
    }
}
