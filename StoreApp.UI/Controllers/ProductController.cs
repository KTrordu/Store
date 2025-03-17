using Microsoft.AspNetCore.Mvc;
using StoreApp.DAL.ApplicationDbContext;

namespace StoreApp.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;

        public ProductController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var model = _db.Products.ToList();

            return await Task.FromResult((IActionResult) View(model));
        }
    }
}
