using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Journal> Journals { get; set; }
        public DbSet<ListTruck> ListTrucks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=IziLogistik.db");
        }
    }
}
