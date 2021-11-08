/* Napisz program obliczający liczbę pierwiastków równania kwadratowego. Program ma 
prosić użytkownika o podanie współczynników równania, a następnie ma wyświetlić 
stosowny komunikat */

using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liczby typu double to z przecinkiem, nie z kropka np. 2,5   nie 2.5
            double a, b, c;
            Console.WriteLine("Podaj wspolczynnik a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            c = double.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            double dzielnik = 2 * a;
            if (delta > 0 && dzielnik != 0)
            {
                Console.WriteLine("Rownanie ma 2 pierwiastki");
                Console.ReadKey();
            }
            else if (delta < 0 || dzielnik == 0)
            {
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiazania");
                    Console.ReadKey();
                }
                else Console.WriteLine("Zakaz dzielenia przez 0");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Rownanie ma 1 rozwiazanie");
                Console.ReadKey();
            }
        }
    }
}

//Urszula B.
