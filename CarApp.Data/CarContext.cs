using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CarApp.Domain;

namespace CarApp.Data
{
    public class CarContext : DbContext
    {
       public DbSet<Car> cars { get; set; }
       public DbSet<Manufacturer> manufacturers { get; set; }
        public ILoggerFactory ConsoleLoggerFactory { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLoggerFactory(ConsoleLoggerFactory).EnableSensitiveDataLogging()
                    .UseSqlServer("Data Source = (localdb)\\MSQLLocalDB; Initial Catalog = CarAppData");
            }
        }
    }
}
