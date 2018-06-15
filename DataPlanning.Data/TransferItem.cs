using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class TransferItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int TransferId { get; set; }

        public Item Item { get; set; }
        public Transfer Transfer { get; set; }
    }
}
