using Microsoft.EntityFrameworkCore;
using POS.Shared.DTO;
using PosServer.Entities;
using PosServer.Repositories;

namespace PosServer.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _repository;

        public MenuService(IMenuRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MenuDto>> GetAllAsync()
        {
            var menus = await _repository.GetAllAsync();
            return menus.Select(m => new MenuDto
            {
                Id = m.Id,
                Name = m.menuName,
                Price = m.menuPrice
            }).ToList();
        }

        public async Task<MenuDto?> GetByIdAsync(int id)
        {
            var menu = await _repository.GetByIdAsync(id);
            return menu == null ? null : new MenuDto
            {
                Id = menu.Id,
                Name = menu.menuName,
                Price = menu.menuPrice
            };
        }

        public async Task<MenuDto> AddAsync(MenuDto dto)
        {
            var entity = new MenuEntity
            {
                menuName = dto.Name,
                menuPrice = dto.Price
            };
            await _repository.AddAsync(entity);
            dto.Id = entity.Id;
            return dto;
        }

        public async Task<bool> UpdateAsync(int id, MenuDto dto)
        {
            var menu = await _repository.GetByIdAsync(id);
            if (menu == null) return false;

            menu.menuName = dto.Name;
            menu.menuPrice = dto.Price;
            await _repository.UpdateAsync(menu);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var menu = await _repository.GetByIdAsync(id);
            if (menu == null) return false;
            await _repository.DeleteAsync(menu);
            return true;
        }
    }
}