using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportesDeVentasAPI2.Data;
using ReportesDeVentasAPI2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportesDeVentasAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSales()
        {
            return await _context.Sales
                .Include(s => s.Product)
                .ToListAsync();
        }
    }
}
