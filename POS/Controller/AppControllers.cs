using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity;
using POS.Repository;

namespace POS.Controller
{
    public class AppControllers
    {
        public static AppControllers Instance { get; } = new AppControllers();

        public TableController TableController { get; }
        // public OrderController OrderController { get; }

        private AppControllers()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql("server=localhost;port=3306;database=posdb;user=root;password=Aa001129!;",
                          new MySqlServerVersion(new Version(8, 4, 5)))
                .Options;

            var context = new AppDbContext(options);

            TableController = new TableController(new TableRepository(context));
            // OrderController = new OrderController(new OrderRepository(context));
        }
    }
}
