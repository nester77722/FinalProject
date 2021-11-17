using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetLogger();

            logger.AddLog("TestLog");
            Console.WriteLine(logger.Logs);

            Logger newLogger = Logger.GetLogger();
            Console.WriteLine(newLogger.Logs);

            newLogger.AddLog("NewLoggerLog");

            Console.WriteLine(logger.Logs);
        }
    }
}
