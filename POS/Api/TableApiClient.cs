using System.Net.Http;
using System.Net.Http.Json;
using POS.Shared.DTO;

namespace POS.Api
{
    public class TableApiClient
    {
        private readonly HttpClient _http;

        public TableApiClient()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7170/") // 포트는 서버에서 확인
            };
        }

        public async Task<List<TableDto>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<TableDto>>("api/table") ?? new List<TableDto>();
        }

        public async Task<TableDto?> GetByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<TableDto>($"api/table/{id}");
        }

        public async Task<bool> AddAsync(TableDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/table", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, TableDto dto)
        {
            var response = await _http.PutAsJsonAsync($"api/table/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/table/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
