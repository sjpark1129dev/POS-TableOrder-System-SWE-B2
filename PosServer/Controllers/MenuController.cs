using Microsoft.AspNetCore.Mvc;
using POS.Shared.DTO;
using PosServer.Services;

namespace PosServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MenuDto>>> GetAll()
        {
            return await _menuService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MenuDto>> GetById(int id)
        {
            var result = await _menuService.GetByIdAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Add(MenuDto dto)
        {
            var created = await _menuService.AddAsync(dto);
            return Ok(created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MenuDto dto)
        {
            var success = await _menuService.UpdateAsync(id, dto);
            if (!success) return NotFound();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _menuService.DeleteAsync(id);
            if (!success) return NotFound();
            return Ok();
        }
    }
}