using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PosServer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Table> Tables { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
