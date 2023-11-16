using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    public class Trucks
    {
        [Key]
        public int ID_Truck { get; set; }
        public string Number { get; set; }
        public string FIO { get; set; }
        public int Status { get; set; }
        public string Car { get; set; }

    }
}
