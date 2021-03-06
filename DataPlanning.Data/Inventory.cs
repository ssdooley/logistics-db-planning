﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class Inventory
    {
        public int Id { get; set; }
        public int PropertyRecordId { get; set; }
        public int UserId { get; set; }
        public DateTime DateStarted { get; set; }
        public string Remarks { get; set; }

        public InventoryVerification InventoryVerification { get; set; }
        public PropertyRecord PropertyRecord { get; set; }
        public User User { get; set; }

        public List<InventoryItem> InventoryItems { get; set; }
    }
}
