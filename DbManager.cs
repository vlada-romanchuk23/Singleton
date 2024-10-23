using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class DbManager
    {
        private static DbManager _instance;
        private static readonly object _lock = new object();

        private DbManager()
        {
            // Ініціалізація підключення до бази даних
        }

        public static DbManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DbManager();
                    }
                    return _instance;
                }
            }
        }

        public void Connect()
        {
            // Код для підключення до бази даних
            Console.WriteLine("Database connected.");
        }
    }
}

