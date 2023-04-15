using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class Delete : AddToFile
    {
        public void DeleteFile()
        {
            path.Append(@"Plik.txt");
            if (File.Exists(path.ToString()))
            {
                try
                {
                    // usunięcie pliku
                    File.Delete(path.ToString());

                    Console.WriteLine($"Plik {path.ToString()} został usunięty.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Wystąpił błąd podczas usuwania pliku {path.ToString()}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Plik {path.ToString()} nie istnieje i nie może być usunięty.");
            }
        }
    }
}
