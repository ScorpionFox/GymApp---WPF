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
        string baza = "Data Source=DESKTOP-1D66II7;Initial Catalog=PROJECT;Integrated Security=True";

        public DbSet<Karnety> Karnety { get; set; }
        public DbSet<Klienci> Klienci { get; set; }
        public DbSet<Rabaty> Rabaty { get; set; }
        public DbSet<Trenerzy> Trenerzy { get; set; }
        public DbSet<Typy_Karnetu> Typy_Karnetu { get; set; }
    }
}
