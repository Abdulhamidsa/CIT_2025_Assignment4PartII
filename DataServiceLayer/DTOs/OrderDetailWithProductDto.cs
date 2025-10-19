namespace DataServiceLayer.DTOs
{
    public class OrderDetailWithProductDto
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public string? CategoryName { get; set; }
        public ProductDto? Product { get; set; }
    }
}