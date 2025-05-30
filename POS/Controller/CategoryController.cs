using POS.Domain;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Controller
{
    public class CategoryController
    {
        private CategoryRepository categoryRepository = new CategoryRepository();

        public List<CategoryEntity> GetAllCategory()
        {
            return categoryRepository.GetAllCategory();
        }

        public void createCategory(string categoryName)
        {
            var newCategory = new CategoryEntity
            {
                CategoryName = categoryName
            };
            categoryRepository.Insert(newCategory);
        }

        public void deleteCategory(CategoryEntity seletedcategory)
        {
            categoryRepository.Delete(seletedcategory);
        }

        public void editCategory(CategoryEntity seletedcategory)
        {
            categoryRepository.Update(seletedcategory);
        }
    }
}
