using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
