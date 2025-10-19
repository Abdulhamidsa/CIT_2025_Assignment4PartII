namespace DataServiceLayer.DTOs
{
    public class OrderDetailForProductDto
    {
        public OrderForTestDto? Order { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}