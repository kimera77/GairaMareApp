using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GaiaMare.Domain;
using GaiaMare.Infrastructure;

namespace GaiaMare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Inventory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventory>>> GetInventory()
        {
            // Trae toda la lista de ítems físicos del almacén
            return await _context.Inventory.ToListAsync();
        }

        // GET: api/Inventory/sku/GAIA-TOTE-BRW-001
        [HttpGet("sku/{sku}")]
        public async Task<ActionResult<Inventory>> GetBySku(string sku)
        {
            var item = await _context.Inventory
                .FirstOrDefaultAsync(i => i.SKU == sku);

            if (item == null) return NotFound();

            return item;
        }
    }
}