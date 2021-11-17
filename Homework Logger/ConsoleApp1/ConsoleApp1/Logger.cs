using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger
    {
        private string _logs = string.Empty;
        public string Logs 
        {
            get
            {
                return _logs;
            }
        }
        public void AddLog(string message)
        {
            _logs += $"\n{DateTime.Now}: {message}";
        }
    }
}
