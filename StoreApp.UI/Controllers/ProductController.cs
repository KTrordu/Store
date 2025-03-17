using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.DAL.ApplicationDbContext;
using StoreApp.Domain.Entities;

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

        public async Task<IActionResult> Get(int id)
        {
            Product product = await _db.Products.FirstOrDefaultAsync(p => p.Id == id);
            return View(product);
        }
    }
}
