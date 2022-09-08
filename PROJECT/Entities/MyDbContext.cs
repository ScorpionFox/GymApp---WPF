using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PROJECT.Entities
{
    /// <summary>
    /// Połączenie z bazą danych i reprezentacje tabeli
    /// </summary>
    class MyDbContext : DbContext
    {
        string baza = "Data Source=MATEUSZ;Initial Catalog=Proj;Integrated Security=True";

        //Reprezentacja tabeli w bazie danych
        public DbSet<Karnet> Karnet { get; set; }
        public DbSet<Klienci> Klienci { get; set; }
        public DbSet<Rabat> Rabat { get; set; }
        public DbSet<Trenerzy> Trenerzy { get; set; }    

        /// <summary>
        /// Łączenie z bazą danych
        /// </summary>

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(baza);
        }
    }
}

