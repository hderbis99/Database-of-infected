using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class DeleteFromFile : AddToFile
    {
        public void DeleteFromFile1()
        {
            path.Append(@"Plik.txt");

            try
            {
                StreamReader sr = File.OpenText(path.ToString());
                string s = "";
                int j = 0;
                Console.WriteLine("Osoby:");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(j++ + ". " + s);
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Brak utworzonego pliku");
            }

            string[] lines = File.ReadAllLines(path.ToString()); // Odczyt wszystkich linii z pliku
            List<string> linesList = new List<string>(lines);
            Console.WriteLine("Wybierz osobę np: 1");
            string variable = Console.ReadLine(); // Pobieranie zmiennej od User'a
            int i = int.Parse(variable);
            try
            {
                linesList.RemoveAt(i); // Usuwamy daną linię
                File.WriteAllLines(path.ToString(), linesList.ToArray()); //Zapis zmodyfikowanej listy za pomocą metody WriteAllLines
            }
            catch
            {
                Console.WriteLine("Brak osoby");
            }
        }
    }
}
