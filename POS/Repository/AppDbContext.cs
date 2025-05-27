using Microsoft.EntityFrameworkCore;
using POS.Entity;

namespace POS.Repository
{
    public class AppDbContext : DbContext
    {
        private static AppDbContext? _instance;
        public static AppDbContext Instance => _instance ??= new AppDbContext();

        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }
        // public DbSet<OrderEntity> Orders { get; set; }
        // public DbSet<UserEntity> Users { get; set; }

        public AppDbContext() : base(
            new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql("server=sjpark1129dev.iptime.org;port=8443;database=posdb;user=root;password=DeuComputerB2!;",
                    new MySqlServerVersion(new Version(8, 4, 5)))
                .Options
            )
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API 설정
            base.OnModelCreating(modelBuilder);
        }
    }
}
