using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Request
{
    public class RegistrationRequest
    {
        public string password { get; set; }
        public string login { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
}
