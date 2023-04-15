using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class ReadFromFile : AddToFile
    {
        public void ReadFromFile1()
        {
            try
            {
                path.Append(@"Plik.txt");
                StreamReader sr = File.OpenText(path.ToString());
                string s = "";
                int i = 0;
                Console.WriteLine("Osoby:");
                while((s = sr.ReadLine()) !=null)
                {
                    Console.WriteLine(i++ + ". " + s);
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Brak utworzonego pliku");
            }
        }
    }
}
