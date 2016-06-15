using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredLogTester
{
    class Program
    {
        private static ILogger logger;

        static void Main(string[] args)
        {
            InitializeSerilog();

            AndLogAStruct();

            AndLogAnObject();

            Console.ReadLine();
        }

        private static void AndLogAStruct()
        {
            var log = "little cat";
            logger.Information("This is a wonderful {log}", log);
        }

        private static void AndLogAnObject()
        {
            var log = new { Animal = "cat", Name = "astroph" };
            logger.Information("This is a wonderful {log}", log);
            logger.Information("This is a wonderful {@log}", log);

            var fruit = new[] { "Apple", "Pear", "Orange" };
            logger.Information("In my bowl I have {Fruit}", fruit);
        }

        private static void InitializeSerilog()
        {
            logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .MinimumLevel.Debug()
                .Enrich.WithThreadId()
                .Enrich.WithProperty("MyMetaProperty", "Oh! the beautiful value!")
                .WriteTo.ColoredConsole()
                .WriteTo.File(@".\myLogFile.txt")
                //.WriteTo.EventLog("Serilog tests")
                .CreateLogger();
        }
    }
}
