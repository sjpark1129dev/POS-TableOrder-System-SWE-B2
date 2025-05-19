using POS.Api;
using POS.Shared.DTO;

namespace POS.Controller
{
    public class TableController
    {
        private readonly TableApiClient _apiClient;

        public TableController()
        {
            _apiClient = new TableApiClient();
        }
        public Task<List<TableDto>> GetAllTablesAsync() => _apiClient.GetAllAsync();

        public Task<TableDto?> GetByIdAsync(int id) => _apiClient.GetByIdAsync(id);

        public Task<bool> CreateTableAsync(string name)
        {
            var dto = new TableDto { Name = name };
            return _apiClient.AddAsync(dto);
        }

        public Task<bool> UpdateTableAsync(TableDto dto)
        {
            return _apiClient.UpdateAsync(dto.Id, dto);
        }

        public Task<bool> DeleteTableAsync(int id)
        {
            return _apiClient.DeleteAsync(id);
        }

        public bool IsDuplicateName(List<TableDto> list, string name)
        {
            return list.Any(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}