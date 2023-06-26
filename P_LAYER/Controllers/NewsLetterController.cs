using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using E_LAYER.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());

		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}


		[HttpPost]
		public PartialViewResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus = true;
			nm.AddNewsLetter(p);
			return PartialView();
		}
	}
}
