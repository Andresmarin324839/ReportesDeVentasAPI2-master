using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportesDeVentasAPI2.Data;
using ReportesDeVentasAPI2.Models;
using ReportesDeVentasAPI2.Models.DTOs;
using ReportesDeVentasAPI2.services;
using ReportesDeVentasAPI2.Services.Interfaces;

namespace ReportesDeVentasAPI2.services
{
    public class SalesService : ISalesService
    {
        private readonly AppDbContext _context;

        public SalesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductSummaryDto>> GetSalesSummary()
        {
            return await _context.Sales
                .Include(s => s.Product)
                .GroupBy(s => new { s.ProductId, s.Product.Name })
                .Select(g => new ProductSummaryDto
                {
                    ProductName = g.Key.Name,
                    TotalSold = g.Sum(s => s.Total),
                    UnitsSold = g.Sum(s => s.Quantity)
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<DailySalesDto>> GetDailySales(DateTime startDate, DateTime endDate)
        {
            return await _context.Sales
                .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                .GroupBy(s => s.SaleDate.Date)
                .Select(g => new DailySalesDto
                {
                    Date = g.Key,
                    TotalSales = g.Sum(s => s.Total),
                    TransactionCount = g.Count()
                })
                .OrderBy(d => d.Date)
                .ToListAsync();
        }

        public async Task<IEnumerable<TopProductsDto>> GetTopProducts(int numberOfProducts)
        {
            return await _context.Sales
                .Include(s => s.Product)
                .GroupBy(s => new { s.Product.Id, s.Product.Name })
                .Select(g => new TopProductsDto
                {
                    ProductId = g.Key.Id,
                    ProductName = g.Key.Name,
                    TotalQuantity = g.Sum(s => s.Quantity),
                    TotalRevenue = g.Sum(s => s.Total)
                })
                .OrderByDescending(p => p.TotalQuantity)
                .Take(numberOfProducts)
                .ToListAsync();
        }
    }
}
