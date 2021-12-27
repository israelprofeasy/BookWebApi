using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
