using PosServer.Entities;

namespace PosServer.Repositories
{
    public interface IMenuRepository
    {
        Task<List<MenuEntity>> GetAllAsync();
        Task<MenuEntity?> GetByIdAsync(int id);
        Task AddAsync(MenuEntity entity);
        Task UpdateAsync(MenuEntity entity);
        Task DeleteAsync(MenuEntity entity);
    }
}
