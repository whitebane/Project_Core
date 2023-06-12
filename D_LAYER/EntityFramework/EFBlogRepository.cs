using D_LAYER.Abstract;
using D_LAYER.Concrete;
using D_LAYER.Repositories;
using E_LAYER.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDL
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(x=>x.Category).ToList();
            }
           
        }
    }
}
