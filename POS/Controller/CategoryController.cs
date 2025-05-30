using POS.Domain;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Controller
{
    public  class CategoryController
    {
        private CategoryRepository categoryRepository;

        public List<CategoryEntity> GetAllCategory()
        {
            return categoryRepository.GetAllCategory();
        }

        public void createCategory()
        {

        }

        public void deleteCategory()
        {

        }
        public void editCategory()
        {

        }
    }
}
