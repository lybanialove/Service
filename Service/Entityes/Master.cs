using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entityes
{
    public class Master
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Record> record { get; set; }
    }
}
