namespace ReportesDeVentasAPI2.Models.DTOs

{
    public class DailySalesDto
    {
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
        public int TransactionCount { get; set; }
    }
}
