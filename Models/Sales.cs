
using ReportesDeVentasAPI2.Models;

public class Sale
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public DateTime SaleDate { get; set; }

    public Product? Product { get; set; }
}
