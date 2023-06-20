using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER.Abstract
{
	public interface IBlogService

	{
		void AddBlog(Blog blog);
		void DeleteBlog(Blog blog);

		void UpdateBlog(Blog blog);

		List<Blog> GetAll();
		Blog GetByID(int id);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListWithWriter(int id);
	    
	}
}
