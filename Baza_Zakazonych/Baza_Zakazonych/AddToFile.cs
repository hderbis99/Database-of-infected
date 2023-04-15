using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class AddToFile
    {
        public StringBuilder path = new StringBuilder();
        public  void WriteToFile()
        {
            path.Append(@"Plik.txt");

            StreamWriter sw;

            if(!File.Exists(path.ToString()))
            {
                sw = File.CreateText(path.ToString());
            }
            else
            {
                sw = new StreamWriter(path.ToString(), true);
            }
            string text = Console.ReadLine();
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
