using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values=cm.GetAll();
            return View(values);
        }
    }
}
