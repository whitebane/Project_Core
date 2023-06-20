using B_LAYER.Concrete;
using B_LAYER.ValidationRules;
using D_LAYER.EntityFramework;
using E_LAYER.Concrete;
using FluentValidation.Results;
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
			WriterValidator wv = new WriterValidator();
			ValidationResult results= wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "test";
				wm.AddWriter(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		
		}
	}
}
