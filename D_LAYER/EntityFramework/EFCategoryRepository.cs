using D_LAYER.Abstract;
using D_LAYER.Repositories;
using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_LAYER.EntityFramework
{
    public class EFCategoryRepository:GenericRepository<Category>, ICategoryDL
    {
        

    }
}
