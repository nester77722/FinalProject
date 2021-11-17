using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.AddLog("TestLog");
            Console.WriteLine(logger.Logs);
        }
    }
}
