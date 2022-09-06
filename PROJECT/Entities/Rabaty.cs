using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    class Rabaty
    {
        [Key]
        public int Numer_seryjny { get; set; }
        public int Wartosc { get; set; }
    }
}
