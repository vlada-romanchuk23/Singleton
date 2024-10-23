using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class DocumentSaver
    {
        private static DocumentSaver _instance;
        private static readonly object _lock = new object();

        private DocumentSaver()
        {
            // Ініціалізація
        }

        public static DocumentSaver Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DocumentSaver();
                    }
                    return _instance;
                }
            }
        }

        public void SaveDocument(string document)
        {
            // Код для збереження документа
            Console.WriteLine($"Document saved: {document}");
        }
    }
}

