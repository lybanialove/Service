using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Request
{
    public class RecordingRequest
    {
        public DateTime dateTime { get; set; }
        public string master { get; set; }
        public string fi { get; set; }
        public string option { get; set; }
    }
}
