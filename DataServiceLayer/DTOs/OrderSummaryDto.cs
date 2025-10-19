using System;

namespace DataServiceLayer.DTOs
{
    public class OrderSummaryDto
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShipName { get; set; }
        public string? ShipCity { get; set; }
    }
}