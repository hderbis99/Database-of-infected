using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class FindInFile : AddToFile
    {
        public void FindInFile1()
        {
            path.Append(@"Plik.txt");
            kod1:
            Console.WriteLine("Chcesz wyszukać po numerze PESEL - 1");
            Console.WriteLine("Inaczej - 2");
            /*
            Security Sec1 = new Security();
            if()
            */
            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine().ToString());

            int a = int.Parse(sb.ToString());
            Security s1 = new Security();

            if (s1.Sec2(a) == false)
            {
                goto kod1;
            }
            switch(a)
            {
                case 1:
                    Console.WriteLine("Wpisz numer PESEL lub jego fragment np. 870316");
                    sb.Clear();
                    sb.Append(Console.ReadLine());
                    double b = double.Parse(sb.ToString());

                    StreamReader reader = new StreamReader(path.ToString());
                    string line = null;
                    while((line = reader.ReadLine()) !=null)
                    {
                        if(line.Contains(b.ToString()))
                        {
                            Console.WriteLine(line);
                        }
                    }
                    reader.Close();
                    break;
                case 2:
                    Console.WriteLine("Wpisz nazwę użytkownika np. Jan Kowalski lub jego STAN: Chory/Podjerzany/Zdrowy");
                    sb.Clear();
                    sb.Append(Console.ReadLine().ToString());
                    StreamReader reader2 = new StreamReader(path.ToString());
                    string line2 = null;

                    while ((line2 = reader2.ReadLine()) != null)
                    {
                        if (line2.Contains(sb.ToString()))
                        {
                            Console.WriteLine(line2);
                        }
                    }
                    reader2.Close();

                    break;
            }
        }
    }
}
