using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult Details(int id) 
        {
            ViewBag.i= id;
            var values=bm.GetBlogByID(id);
            return View(values);

        }


    } 
}
