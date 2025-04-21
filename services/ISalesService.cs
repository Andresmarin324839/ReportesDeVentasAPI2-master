using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReportesDeVentasAPI2.Models.DTOs;

namespace ReportesDeVentasAPI2.Services.Interfaces
{
    public interface ISalesService
    {
        Task<IEnumerable<ProductSummaryDto>> GetSalesSummary();
        Task<IEnumerable<DailySalesDto>> GetDailySales(DateTime startDate, DateTime endDate);
        Task<IEnumerable<TopProductsDto>> GetTopProducts(int numberOfProducts);
    }
}