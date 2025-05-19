using POS.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;

namespace POS.Api
{
    public class MenuApiClient
    {
        private readonly HttpClient _http;

        public MenuApiClient()
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://localhost:7170/"); // 포트는 Swagger에서 확인
        }

        public async Task<List<MenuDto>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<MenuDto>>("api/menu") ?? new List<MenuDto>();
        }

        public async Task<MenuDto?> GetByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<MenuDto>($"api/menu/{id}");
        }

        public async Task<bool> AddAsync(MenuDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/menu", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, MenuDto dto)
        {
            var response = await _http.PutAsJsonAsync($"api/menu/{id}", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/menu/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}