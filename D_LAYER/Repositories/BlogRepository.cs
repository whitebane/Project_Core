using D_LAYER.Abstract;
using D_LAYER.Concrete;
using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.Repositories
{
    public class BlogRepository : IBlogDL
    {
        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}
