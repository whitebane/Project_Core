using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.Abstract
{
    public interface IBlogDL:IGenericDL<Blog>
    {
        List<Blog> GetListWithCategory();


    }
}
