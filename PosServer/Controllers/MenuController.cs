using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Shared.DTO;
using PosServer;
using PosServer.Entities;

namespace PosServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MenuController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MenuDto>>> GetAll()
        {
            var menus = await _context.Menus.ToListAsync();
            return menus.Select(m => new MenuDto
            {
                Id = m.Id,
                Name = m.menuName,
                Price = m.menuPrice
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MenuDto>> GetById(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu == null) return NotFound();
            return new MenuDto { Id = menu.Id, Name = menu.menuName, Price = menu.menuPrice };
        }

        [HttpPost]
        public async Task<IActionResult> Add(MenuDto dto)
        {
            var menu = new MenuEntity { menuName = dto.Name, menuPrice = dto.Price };
            _context.Menus.Add(menu);
            await _context.SaveChangesAsync();
            dto.Id = menu.Id;
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MenuDto dto)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu == null) return NotFound();

            menu.menuName = dto.Name;
            menu.menuPrice = dto.Price;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu == null) return NotFound();
            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}