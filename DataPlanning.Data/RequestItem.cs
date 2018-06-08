﻿namespace DataPlanning.Data
{
    public class RequestItem
    {
        public int Id { get; set; }
        public int? ItemGroupId { get; set; }
        public int RequestId { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        public ItemGroup ItemGroup { get; set; }
        public Request Request { get; set; }
    }
}
