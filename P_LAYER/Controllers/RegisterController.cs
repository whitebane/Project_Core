using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using E_LAYER.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EFWriterRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p)
		{
			p.WriterStatus = true;
			p.WriterAbout = "test";
			wm.AddWriter(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
