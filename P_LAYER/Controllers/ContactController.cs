using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using E_LAYER.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p) 
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            cm.ContactAdd(p);


            return RedirectToAction("Index","Blog");
        }
    }
}
