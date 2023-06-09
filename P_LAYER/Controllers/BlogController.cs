using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
