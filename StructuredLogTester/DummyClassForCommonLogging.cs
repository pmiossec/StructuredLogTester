using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredLogTester
{
    class DummyClassForCommonLogging
    {
        private ILog _logger;

        public DummyClassForCommonLogging()
        {
            _logger = LogManager.GetLogger<DummyClassForCommonLogging>();
        }

        public void IDoNothingButIDoItWell()
        {
            var dataToLog = new DtoToLog
            {
                Bool = true,
                Decimal = 54.789m,
                Int = 34,
                String = "Top top"
            };
            _logger.Info(m=>m("Even with Common.Logging, i still can log structured {@data}", dataToLog));
            _logger.Info(m=>m("but if I log with {0} synthax, it ends with {1}", "good old 'string format'", "plain text logs :("));
        }
    }
}
