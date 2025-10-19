using System;
using System.Collections.Generic;

namespace DataServiceLayer.DTOs
{
    public class OrderWithDetailsDto
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShipName { get; set; }
        public string? ShipCity { get; set; }
        public List<OrderDetailWithProductDto>? Details { get; set; }
    }
}