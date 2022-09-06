using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    class Karnety
    {
        
        [Key]
        public int Numer_seryjny { get; set; }
        public DateTime Data_zakupu { get; set; }
        public DateTime Data_waznosci { get; set; }
        public int ID_Klient { get; set; }
        public string Typ_Karnetu { get; set; }
    }
}
