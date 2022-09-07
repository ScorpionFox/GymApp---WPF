using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PROJECT.Entities
{
    class Karnet
    {
        
        [Key]
        public int Id { get; set; }
        public DateTime Data_zakupu { get; set; }
        public DateTime Data_waznosci { get; set; }      
    }
}
