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

        public CategoryEntity GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Insert(CategoryEntity category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(CategoryEntity category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(CategoryEntity category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
