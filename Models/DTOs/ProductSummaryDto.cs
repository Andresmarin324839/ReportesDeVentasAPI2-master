namespace ReportesDeVentasAPI2.Models.DTOs
{
    public class ProductSummaryDto
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public decimal TotalSold { get; set; }
        public int UnitsSold { get; set; }
    }
}