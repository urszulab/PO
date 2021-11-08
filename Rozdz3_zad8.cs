/*Zadanie 3.8.
Pobierz od użytkownika wartość średniej ocen. Program ma wyświetlać informacje o 
wysokości przysługującego stypendium zgodnie z poniższą tabelą:
 */

using System;

namespace rozdzial3
{
    class Program
    {
        public const double pp1 = 2.00; //pierwszy przedzial 1. liczba - poczatek
        public const double pp2 = 3.99; //pierwsyz przedzial 2. liczba- koniec
        public const double dp1 = 4.00; //drugi przedzial 1. liczba
        public const double dp2 = 4.79;// drugi przedz. 2. liczba
        public const double tp1 = 4.80; //trzeci przedzial 1. liczba
        public const double tp2 = 5.00; // trzeci przedzial 2. liczba

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj srednia:");
            double srednia = double.Parse(Console.ReadLine());
            if (srednia >= pp1 && srednia <= pp2)
            {
                Console.WriteLine("Kwota przyslugujaca to: 0,00 zl");
            }
            else if (srednia >= dp1 && srednia <= dp2)
            {
                Console.WriteLine("Kwota przyslugujaca to: 350,00 zl");
            }
            else if (srednia >= tp1 && srednia <= tp2)
            {
                Console.WriteLine("Kwota przyslugujaca to: 550,00 zl");
            }
            else Console.WriteLine("Podano srednia spoza skali");
            Console.ReadKey();
        }
    }
}

//Urszula B.
