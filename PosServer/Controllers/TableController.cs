// ✅ PosServer/Controllers/TableController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS.Shared.DTO;
using PosServer;
using PosServer.Entities;

namespace PosServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TableController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TableController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TableDto>>> GetAll()
        {
            var tables = await _context.Tables.ToListAsync();
            return tables.Select(t => new TableDto
            {
                Id = t.Id,
                Name = t.tableName
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TableDto>> GetById(int id)
        {
            var table = await _context.Tables.FindAsync(id);
            if (table == null) return NotFound();
            return new TableDto { Id = table.Id, Name = table.tableName };
        }

        [HttpPost]
        public async Task<IActionResult> Add(TableDto dto)
        {
            var table = new TableEntity { tableName = dto.Name };
            _context.Tables.Add(table);
            await _context.SaveChangesAsync();
            dto.Id = table.Id;
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TableDto dto)
        {
            var table = await _context.Tables.FindAsync(id);
            if (table == null) return NotFound();

            table.tableName = dto.Name;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var table = await _context.Tables.FindAsync(id);
            if (table == null) return NotFound();
            _context.Tables.Remove(table);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}