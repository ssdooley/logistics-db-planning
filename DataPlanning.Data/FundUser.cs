﻿namespace DataPlanning.Data
{
    public class FundUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
