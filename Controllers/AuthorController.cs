using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
