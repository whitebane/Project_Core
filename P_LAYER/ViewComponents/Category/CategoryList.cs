using B_LAYER.Concrete;
using D_LAYER.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace P_LAYER.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EFCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values = cm.GetAll();
			return View(values);
		}
	}
}
