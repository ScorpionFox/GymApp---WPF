using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROJECT.Entities
{
    class MyDbContext : DbContext
    {
        string baza = "Data Source=DESKTOP-1D66II7;Initial Catalog=Proj;Integrated Security=True";

        public DbSet<Karnet> Karnet { get; set; }
        public DbSet<Klienci> Klienci { get; set; }
        public DbSet<Rabat> Rabat { get; set; }
        public DbSet<Trenerzy> Trenerzy { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(baza);
        }
    }
}

