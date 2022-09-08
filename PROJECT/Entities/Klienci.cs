using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    /// <summary>
    /// Odzworowanie tabeli Klienci z bazy danych w kodzie
    /// </summary>
    class Klienci
    {
        [Key]
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int? IdTrener { get; set; }
        public int? IdRabat { get; set; }
        public int? IdKarnet { get; set; }
    }
}
