using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    public class Journal
    {
        public int ID_Zayavki { get; set; }
        public string Status { get; set; }
        public string Zakazchik { get; set; }
        public string Address { get; set; }
        public string Name_Gryuz { get; set; }
        public int Count { get; set; }
        public string Car { get; set; }
        public string Date_Otgryzki { get; set; }

    }
}
