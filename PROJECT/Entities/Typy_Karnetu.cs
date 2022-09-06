using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    class Typy_Karnetu
    {
        [Key]
        public string Typ { get; set; }
        public string Okres_waznosci { get; set; }
    }
}
