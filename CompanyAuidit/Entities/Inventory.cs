﻿namespace CompanyAuidit.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Cost { get; set; }

        public List<UserAndInventoriyRelationship> userAndInventoriyRelationships { get; set; }
    }
}