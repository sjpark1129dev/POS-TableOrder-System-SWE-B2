using Microsoft.EntityFrameworkCore;

namespace POS.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<SalesEntity> Sales { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API 설정
            base.OnModelCreating(modelBuilder);
        }
    }
}
