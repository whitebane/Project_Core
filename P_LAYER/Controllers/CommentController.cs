using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
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

		public PartialViewResult AddComment()
		{
			return PartialView();
		}

		public PartialViewResult CommentList(int id)
		{
		    var values=cm.GetAll(id);
			return PartialView(values);
		}
	}
}
