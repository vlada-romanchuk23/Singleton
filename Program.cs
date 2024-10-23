using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonLibrary;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Використання DbManager
            DbManager.Instance.Connect();
            Logger.Instance.Log("Database connected.");

            // Використання DocumentSaver
            DocumentSaver.Instance.SaveDocument("Document content");
            Logger.Instance.Log("Document saved.");

            // Логування інформації
            Logger.Instance.Log("Application finished.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

