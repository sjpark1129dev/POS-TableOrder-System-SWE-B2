using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain
{
    public static class DbContextFactory
    {
        private static readonly DbContextOptions<AppDbContext> _options;

        static DbContextFactory()
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseMySql(
                "server=sjpark1129dev.iptime.org;port=8443;database=posdb;user=root;password=DeuComputerB2!;",
                new MySqlServerVersion(new Version(8, 4, 5))
            );

            _options = builder.Options;
        }

        public static AppDbContext Create()
        {
            return new AppDbContext(_options);
        }
    }
}
