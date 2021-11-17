using System;

namespace ConsoleApp1
{
    public class Logger
    {
        private static Logger _instance;

        private string _logs = string.Empty;

        public string Logs 
        {
            get
            {
                return _logs;
            }
        }

        public static Logger GetLogger()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void AddLog(string message)
        {
            _logs += $"\n{DateTime.Now}: {message}";
        }

        private Logger()
        { }
    }
}
