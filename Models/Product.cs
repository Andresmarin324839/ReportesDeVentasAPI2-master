using System.ComponentModel.DataAnnotations;

namespace ReportesDeVentasAPI2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }

};