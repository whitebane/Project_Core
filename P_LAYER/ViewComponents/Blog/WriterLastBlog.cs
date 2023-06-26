using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace P_LAYER.ViewComponents.Blog
{
	public class WriterLastBlog: ViewComponent
	{

		BlogManager bm = new BlogManager(new EFBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListWithWriter(1);
			return View(values);
		}
	}
}
