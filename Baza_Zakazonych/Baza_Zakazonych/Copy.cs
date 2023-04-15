using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class Copy : AddToFile
    {
        public void CopyFile()
        {
            path.Append(@"Plik.txt");
            string sourceFilePath = path.ToString();
            string destinationFilePath = @"C:\Users\hderb\Documents\Visual_Projekty\Baza_Zakazonych\Data_copy\Plik.txt";

            Console.Write("Podaj liczbę kopii: ");
            int numberOfCopies = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCopies; i++)
            {
                string newDestinationFilePath = Path.Combine(Path.GetDirectoryName(destinationFilePath),
                                                         $"{Path.GetFileNameWithoutExtension(destinationFilePath)}_{i}{Path.GetExtension(destinationFilePath)}");
                // skopiuj plik z nadpisywaniem
                File.Copy(sourceFilePath, newDestinationFilePath, true);
                Console.WriteLine($"Skopiowano plik {newDestinationFilePath}");
            }
            Console.WriteLine("Wszystkie kopie zostały utworzone.");
        }
    }
}
