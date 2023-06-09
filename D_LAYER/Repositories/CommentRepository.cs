using D_LAYER.Abstract;
using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.Repositories
{
    public class CommentRepository : IGenericDL<Comment>
    {
        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
