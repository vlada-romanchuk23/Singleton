using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SingletonLibrary
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private string _logFilePath = "log.txt";

        private Logger()
        {
            // Ініціалізація
        }

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            File.AppendAllText(_logFilePath, $"{DateTime.Now}: {message}\n");
            Console.WriteLine($"Log: {message}");
        }
    }
}
