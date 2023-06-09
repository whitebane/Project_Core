using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.Abstract
{
    public interface IGenericDL<T> where T: class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);   
        List<T> GetAll();

        T GetById(int id);
    }
}
