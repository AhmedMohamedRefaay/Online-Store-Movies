using Microsoft.AspNetCore.Mvc;

namespace Online__Store_Movies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
