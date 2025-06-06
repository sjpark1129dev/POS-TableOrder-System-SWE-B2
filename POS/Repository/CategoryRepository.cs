using Microsoft.EntityFrameworkCore;
using POS.Controller;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    public class CategoryRepository
    {
        private readonly AppDbContext _context = AppDbContext.Instance;

        public List<CategoryEntity> GetAllCategory()
        {
            return _context.Categories.AsNoTracking().ToList();
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
            var existing = _context.Categories.Find(category.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(category);
                _context.SaveChanges();
            }
        }

        public void Delete(CategoryEntity category)
        {
            var existing = _context.Categories.Find(category.Id);
            if (existing != null)
            {
                _context.Categories.Remove(existing);
                _context.SaveChanges();
            }
        }
        public bool HasMenus(int categoryId)
        {
            return _context.Menus.Any(m => m.CategoryId == categoryId);
        }
    }
}
