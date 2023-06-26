using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using E_LAYER.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult AddComment()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult AddComment(Comment p)
		{
			p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 2;
			cm.AddComment(p);
			return PartialView();
		}


		public PartialViewResult CommentList(int id)
		{
		    var values=cm.GetAll(id);
			return PartialView(values);
		}
	}
}
