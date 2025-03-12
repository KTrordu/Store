using Microsoft.AspNetCore.Mvc;

namespace StoreApp.UI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return await Task.FromResult((IActionResult) View());
        }
    }
}