using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DatabaseFirstMigration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DImProductController : ControllerBase
    {
        private readonly AdventureWorksDw2019Context _context;
        public DImProductController(AdventureWorksDw2019Context context) { 
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<DimProduct>>> GetDimProducts()
        {
            return Ok(await _context.DimProducts
                //.Include(p => p.DimProductSubcategory)
                .ToListAsync());
        }
    }
}
 