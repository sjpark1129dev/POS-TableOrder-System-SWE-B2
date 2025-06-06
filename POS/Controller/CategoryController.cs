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
        private CategoryRepository categoryRepository;
        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

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

        public void deleteCategory(CategoryEntity selectedCategory)
        {
            categoryRepository.Delete(selectedCategory);
        }


        public void editCategory(CategoryEntity seletedcategory)
        {
            categoryRepository.Update(seletedcategory);
        }

        public bool IsCategoryInUse(int categoryId)
        {
            return categoryRepository.HasMenus(categoryId);
        }

        public bool IsDuplicateCategoryName(string name, int? excludeId = null)
        {
            var all = categoryRepository.GetAllCategory();
            return all.Any(c => c.CategoryName == name && (!excludeId.HasValue || c.Id != excludeId.Value));
        }
    }
}
