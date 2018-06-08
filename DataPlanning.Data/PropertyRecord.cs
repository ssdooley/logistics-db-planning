﻿using System.Collections.Generic;

namespace DataPlanning.Data
{
    public class PropertyRecord
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }

        public Site Site { get; set; }

        public List<HardwareItem> HardwareItems { get; set; }
        public List<PropertyCustodian> PropertyCustodians { get; set; }
        public List<SerializedItem> SerializedItems { get; set; }
    }
}
