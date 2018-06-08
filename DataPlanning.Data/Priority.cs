using System.Collections.Generic;

namespace DataPlanning.Data
{
    public class Priority
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public List<Request> Requests { get; set; }
    }
}
