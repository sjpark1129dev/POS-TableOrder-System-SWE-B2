using Microsoft.EntityFrameworkCore;
using POS.Entity;

namespace POS.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<TableEntity> Tables { get; set; }
        // public DbSet<MenuEntity> Menus { get; set; }
        // public DbSet<OrderEntity> Orders { get; set; }
        // public DbSet<UserEntity> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API 설정
            base.OnModelCreating(modelBuilder);
        }
    }
}
