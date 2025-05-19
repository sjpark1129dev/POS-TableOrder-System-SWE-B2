using POS.Api;
using POS.Shared.DTO;

namespace POS.Controller
{
    public class MenuController
    {
        private readonly MenuApiClient _apiClient;

        public MenuController()
        {
            _apiClient = new MenuApiClient();
        }

        public Task<List<MenuDto>> GetAllMenusAsync() => _apiClient.GetAllAsync();

        public Task<MenuDto?> GetByIdAsync(int id) => _apiClient.GetByIdAsync(id);

        public Task<bool> CreateMenuAsync(string name, int price)
        {
            var dto = new MenuDto { Name = name, Price = price };
            return _apiClient.AddAsync(dto);
        }

        public Task<bool> UpdateMenuAsync(MenuDto dto)
        {
            return _apiClient.UpdateAsync(dto.Id, dto);
        }

        public Task<bool> DeleteMenuAsync(int id)
        {
            return _apiClient.DeleteAsync(id);
        }

        public bool IsDuplicateName(List<MenuDto> list, string name)
        {
            return list.Any(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}