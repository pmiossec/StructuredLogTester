using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredLogTester
{
    class DtoToLog
    {
        public string String { get; set; }
        public bool Bool { get; set; }
        public int Int { get; set; }
        public decimal Decimal { get; set; }
    }
}
