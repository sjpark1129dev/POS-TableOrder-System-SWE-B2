using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Entity;

namespace PosServer
{
    public class AppDbContext : DbContext
    {
        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
