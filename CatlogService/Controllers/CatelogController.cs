using CatlogService.Database;
using Microsoft.AspNetCore.Mvc;

namespace CatlogService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CatelogController : Controller
    {
        private readonly DatabaseContext _db;
        public CatelogController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listcatelog = _db.Products.ToList();
            return Ok(listcatelog);
        }
    }
}
