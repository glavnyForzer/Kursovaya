using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Kursovaya.classes;
using System.Data.SQLite;

namespace Kursovaya
{

    public class ApplicationContext : DbContext
    {
        public DbSet <Journal> Journal { get; set; }
        public DbSet<Trucks> Trucks { get; set; }
        //public DbSet<StatusZayavki> StatusZayavki { get; set; }
        public DbSet<StatusTrucks> StatusTrucks { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {

        }
    }
}
