using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baza_Zakazonych
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
            kod1:
                Console.WriteLine("Wybierz operacje: ");
                Console.WriteLine("1 - Dodaj osobę");
                Console.WriteLine("2 - Pokaż osoby");
                Console.WriteLine("3 - Usuń osobę");
                Console.WriteLine("4 - Wyszukaj osobę");
                Console.WriteLine("5 - Zrób kopię bazy danych");
                Console.WriteLine("6 - Usuń bazę danych");
                Console.WriteLine("Q - Exit");

                StringBuilder sb = new StringBuilder();
                sb.Append(Console.ReadLine());
                Security s1 = new Security();

                if (s1.Sec1(sb.ToString()) == false)
                {
                    goto kod1;
                }

                switch (sb.ToString())
                {
                    case "1":
                        sb.Clear();
                        bool continueOption1 = true;
                        while (continueOption1)
                        {
                            sb.Clear();
                            Console.WriteLine("Dodaj użytkownika przykład: ");
                            Console.WriteLine("Kowalski Jan PESEL: 00121905678 STAN: Chory/Podjerzany/Zdrowy");
                            AddToFile Add1 = new AddToFile();
                            Add1.WriteToFile();

                            Console.WriteLine("Chcesz dodać kolejną osobę ? (T/N)");
                            sb.Append(Console.ReadLine());

                            if (sb.ToString().ToUpper() != "T")
                            {
                                continueOption1 = false;
                            }
                        }
                        break;
                    case "2":
                        sb.Clear();
                        bool continueOption2 = true;
                        while (continueOption2)
                        {
                            sb.Clear();
                            ReadFromFile Read1 = new ReadFromFile();
                            Read1.ReadFromFile1();
                            Console.WriteLine("Chcesz odczytać osoby jeszcze raz ? (T/N)");
                            sb.Append(Console.ReadLine());

                            if (sb.ToString().ToUpper() != "T")
                            {
                                continueOption2 = false;
                            }
                        }
                        break;
                    case "3":
                        sb.Clear();
                        bool continueOption3 = true;
                        while (continueOption3)
                        {
                            sb.Clear();
                            DeleteFromFile delete1 = new DeleteFromFile();
                            delete1.DeleteFromFile1();
                            Console.WriteLine("Chcesz usunąć kolejną osobę ? (T/N)");
                            sb.Append(Console.ReadLine());

                            if (sb.ToString().ToUpper() != "T")
                            {
                                continueOption3 = false;
                            }
                        }
                        break;
                    case "4":
                        sb.Clear();
                        bool continueOption4 = true;
                        while (continueOption4)
                        {
                            sb.Clear();
                            FindInFile Find1 = new FindInFile();
                            Find1.FindInFile1();
                            Console.WriteLine("Chcesz wyszukać kolejną osobę ? (T/N)");
                            sb.Append(Console.ReadLine());

                            if (sb.ToString().ToUpper() != "T")
                            {
                                continueOption4 = false;
                            }
                        }
                        break;
                    case "5":
                        sb.Clear();
                        bool continueOption5 = true;
                        while (continueOption5)
                        {
                            sb.Clear();
                            Copy Cp1 = new Copy();
                            Cp1.CopyFile();
                            Console.WriteLine("Chcesz wykonać kolejne kopie ? (T/N)");
                            sb.Append(Console.ReadLine());

                            if (sb.ToString().ToUpper() != "T")
                            {
                                continueOption5 = false;
                            }
                        }
                        break;
                    case "6":
                        sb.Clear();
                        bool continueOption6 = true;
                        while (continueOption6)
                        {
                            sb.Clear();
                            Delete Dl1 = new Delete();
                            Dl1.DeleteFile();
                        }
                        Console.WriteLine("Chcesz usunąć kolejne pliki (T/N)");
                        sb.Append(Console.ReadLine());

                        if (sb.ToString().ToUpper() != "T")
                        {
                            continueOption6 = false;
                        }
                        break;

                    case "q":
                    case "Q":
                        exitProgram = true;
                        break;
                }
            }
        }
    }
}
