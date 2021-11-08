/* Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik. operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5 
oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0. */

using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char znak;
            Console.WriteLine("Podaj liczbe a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz znak + lub – lub * lub /: ");
            znak = Convert.ToChar(Console.ReadLine()); // trzeba jawnie przekonwertowac ze stringa (RedLine(); czyta jako string) do chara, bo niejawnie sie nie da
            
            switch (znak)
            {
                case '+':
                    Console.WriteLine("Wynik = {0}", (a + b));
                    break;
                case '-':
                    Console.WriteLine("Wynik = {0}", (a - b));
                    break;
                case '*':
                    Console.WriteLine("Wynik = {0}", (a * b));
                    break;
                case '/':
                    Console.WriteLine("Wynik = {0}", (a / b));
                    break;
                default:
                    Console.WriteLine("Podano zly symbol");
                    break;
            }
            Console.ReadKey();
        }
    }
}
