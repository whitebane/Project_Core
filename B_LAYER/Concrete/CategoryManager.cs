using B_LAYER.Abstract;
using D_LAYER.Abstract;
using D_LAYER.EntityFramework;
using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDL _categoryDL;

     

        public CategoryManager(ICategoryDL categoryDL)
        {
            _categoryDL = categoryDL;
        }

        public void AddCategory(Category category)
        {
            _categoryDL.Insert(category);
            
        }

        public void DeleteCategory(Category category)
        {
            _categoryDL.Delete(category);
        }

        public List<Category> GetAll()
        {
           return _categoryDL.GetAll();
        }

        public Category GetByID(int id)
        {
            return _categoryDL.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDL.Update(category);
        }
    }
}
