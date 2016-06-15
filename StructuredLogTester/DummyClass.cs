using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredLogTester
{
    class DummyClass
    {
        private ILogger _logger;

        public DummyClass(ILogger logger)
        {
            _logger = logger.ForContext<DummyClass>();
        }

        public void IDoNothingButIDoItWell()
        {
            _logger.Information("Log from my class");
        }
    }
}
