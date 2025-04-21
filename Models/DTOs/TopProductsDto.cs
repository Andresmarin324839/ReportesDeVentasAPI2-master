namespace ReportesDeVentasAPI2.Models.DTOs
{
    public class TopProductsDto
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}