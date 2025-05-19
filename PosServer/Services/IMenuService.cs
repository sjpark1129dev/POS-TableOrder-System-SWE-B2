using POS.Shared.DTO;

namespace PosServer.Services
{
    public interface IMenuService
    {
        Task<List<MenuDto>> GetAllAsync();
        Task<MenuDto?> GetByIdAsync(int id);
        Task<MenuDto> AddAsync(MenuDto dto);
        Task<bool> UpdateAsync(int id, MenuDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
