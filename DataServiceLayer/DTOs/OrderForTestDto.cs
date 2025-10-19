using System;
using System.Collections.Generic;

namespace DataServiceLayer.DTOs
{
    public class OrderForTestDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<OrderDetailForTestDto>? OrderDetails { get; set; }
    }

    public class OrderDetailForTestDto
    {
        public ProductForTestDto? Product { get; set; }
    }

    public class ProductForTestDto
    {
        public string? Name { get; set; }
        public CategoryDto? Category { get; set; }
    }
}