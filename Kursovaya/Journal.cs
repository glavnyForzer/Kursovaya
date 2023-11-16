using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya.classes

{
    public class Journal
    {
        [Key]
        public int ID_Zayavki { get; set; }
        public string Owner { get; set; }
        public string Status { get; set; }
        public string Adress { get; set; }
        public string Name_Gruz { get; set; }
        public string Weight { get; set; }
        public int Truck { get; set; }
        public string Date_Otgruzki { get; set; }

    }
}
