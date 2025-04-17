using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistControlShared.Models
{
    public class Trace
    {
        public int IdUser { get; set; }
        public int IdActivity { get; set; }
        public int IdLevel { get; set; }
        public string? Message { get; set; }

    }

}
