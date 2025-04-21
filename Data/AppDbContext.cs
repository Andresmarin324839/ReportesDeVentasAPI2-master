using Microsoft.EntityFrameworkCore;
using ReportesDeVentasAPI2.Models;

namespace ReportesDeVentasAPI2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
