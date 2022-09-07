using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    class Rabat
    {
        [Key]
        public int Id { get; set; }
        public int? Wartosc { get; set; }
    }
}
