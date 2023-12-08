using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entites
{
    public class Record
    {
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        string nameClient { get; set; }
        string surnameClient { get; set; }
    }
}
