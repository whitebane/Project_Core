using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
