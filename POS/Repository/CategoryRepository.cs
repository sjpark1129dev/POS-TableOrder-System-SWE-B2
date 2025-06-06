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
        public List<CategoryEntity> GetAllCategory()
        {
            using var context = DbContextFactory.Create();
            return context.Categories.AsNoTracking().ToList();
        }

        public void Insert(CategoryEntity category)
        {
            using var context = DbContextFactory.Create();
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Update(CategoryEntity category)
        {
            using var context = DbContextFactory.Create();
            var existing = context.Categories.Find(category.Id);
            if (existing != null)
            {
                context.Entry(existing).CurrentValues.SetValues(category);
                context.SaveChanges();
            }
        }

        public void Delete(CategoryEntity category)
        {
            using var context = DbContextFactory.Create();
            var existing = context.Categories.Find(category.Id);
            if (existing != null)
            {
                context.Categories.Remove(existing);
                context.SaveChanges();
            }
        }

        public bool HasMenus(int categoryId)
        {
            using var context = DbContextFactory.Create();
            return context.Menus.Any(m => m.CategoryId == categoryId);
        }
    }
}
