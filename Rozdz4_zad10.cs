/*Zadanie 4.10.
Napisać program, który pobierze datę w formacie DD-MM-RRRR, z której pobierze
miesiąc i wyświetli jego nazwę słownie.
 */

using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Napisz zdanie date w formacie DD-MM-RRRR:  ");
            string data = Console.ReadLine();
            string miesiac = data.Substring(3, 2);
            Console.WriteLine("Miesiac nr " + miesiac);
            switch (miesiac)
            {
                case "01":
                    Console.WriteLine("Jest to styczen.");
                    break;
                case "02":
                    Console.WriteLine("Jest to luty.");
                    break;
                case "03":
                    Console.WriteLine("Jest to marzec.");
                    break;
                case "04":
                    Console.WriteLine("Jest to kwiecien.");
                    break;
                case "05":
                    Console.WriteLine("Jest to maj.");
                    break;
                case "06":
                    Console.WriteLine("Jest to czerwiec.");
                    break;
                case "07":
                    Console.WriteLine("Jest to lipiec.");
                    break;
                case "08":
                    Console.WriteLine("Jest to sierpien.");
                    break;
                case "09":
                    Console.WriteLine("Jest to wrzesien.");
                    break;
                case "10":
                    Console.WriteLine("Jest to pazdziernik.");
                    break;
                case "11":
                    Console.WriteLine("Jest to listopad.");
                    break;
                case "12":
                    Console.WriteLine("Jest to grudzien.");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego miesiaca");
                    break;
            }  
        }
    }
}
//Urszula B.
