using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Entities
{
    class Klienci
    {
        public int Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int ID_Trener { get; set; }
        public int ID_Rabat { get; set; }
    }
}
