using Microsoft.AspNetCore.Mvc;
using P_LAYER.Models;

namespace P_LAYER.ViewComponents
{
	public class CommentList : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName = "Murat"
				},
				new UserComment
				{
					ID = 2,
					UserName = "Kaan"
				},
				new UserComment
				{
					ID = 3,
					UserName = "Beyza"

				}};

			return View(commentvalues);
		}
	}
}
