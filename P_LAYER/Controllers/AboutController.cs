
using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm = new AboutManager(new EFAboutRepository());
		public IActionResult Index()
		{
			var values = abm.GetAll();
			return View(values);
		}

		public PartialViewResult SocialMedia()
		{
		
			return PartialView(); 
		}
	}
}
