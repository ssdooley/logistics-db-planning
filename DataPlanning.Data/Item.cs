using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlanning.Data
{
    public class Item
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemCategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public string Model { get; set; }
        public string Nsn { get; set; }
        public string ItemType { get; set; }

        public Order Order { get; set; }
        public ItemCategory ItemCategory { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }

    public class SerializedItem : Item
    {
        public int PropertyRecordId { get; set; }
        public string SerialNumber { get; set; }
        public string Location { get; set; }

        public PropertyRecord PropertyRecord { get; set; }
    }

    public class HardwareItem : Item
    {
        public int PropertyRecordId { get; set; }
        public string SerialNumber { get; set; }
        public string ServiceTag { get; set; }
        public string MacAddress { get; set; }
        public string Location { get; set; }

        public PropertyRecord PropertyRecord { get; set; }
    }

    public class SoftwareItem : Item
    {
        public int SiteId { get; set; }
        public string License { get; set; }
        public int Users { get; set; }

        public Site Site { get; set; }
    }

    public class NsnItem : Item
    {
        public int SiteId { get; set; }
        public int Quantity { get; set; }

        public Site Site { get; set; }
    }
}
