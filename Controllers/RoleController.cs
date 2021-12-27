using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
