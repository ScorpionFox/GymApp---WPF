using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    class Klienci
    {
        [Key]
        public int Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int ID_Trener { get; set; }
        public int ID_Rabat { get; set; }
    }
}
