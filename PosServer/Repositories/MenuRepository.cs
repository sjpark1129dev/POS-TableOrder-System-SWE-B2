using Microsoft.EntityFrameworkCore;
using PosServer.Entities;

namespace PosServer.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _context;

        public MenuRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<MenuEntity>> GetAllAsync()
        {
            return await _context.Menus.ToListAsync();
        }

        public async Task<MenuEntity?> GetByIdAsync(int id)
        {
            return await _context.Menus.FindAsync(id);
        }

        public async Task AddAsync(MenuEntity entity)
        {
            _context.Menus.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(MenuEntity entity)
        {
            _context.Menus.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(MenuEntity entity)
        {
            _context.Menus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
