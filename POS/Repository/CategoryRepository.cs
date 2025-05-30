using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Controller;
using POS.Domain;

namespace POS.Repository
{
    public class CategoryRepository
    {
        private readonly AppDbContext _context = AppDbContext.Instance;


        public List<CategoryEntity> GetAllCategory()
        {
            return _context.Categories.ToList();

        }

        public void Insert(CategoryRepository category)
        {

        }

        public void Update(CategoryRepository category)
        {

        }
       
        public void Delete(CategoryRepository category)
        {

        }

    }
}
