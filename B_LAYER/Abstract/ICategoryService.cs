using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category); 

        List<Category> GetAll();
        Category GetByID(int id);

    }
}
