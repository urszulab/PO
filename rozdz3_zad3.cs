/* Napisz program pobierający od użytkownika 3 liczby. Program ma wyświetlić wartość 
największej z nich. */

using System;

namespace rozdzial3
{
    class Program   // 5,5,4  , 555, 123
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj liczbe a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");  
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            c = int.Parse(Console.ReadLine()); 
            if (a >= b && a >= c)
            {
                Console.WriteLine("{0} jest najwieksza liczba", a);
            }
            else
            {
                if (b >= a && b >= c)
                {
                    Console.WriteLine("{0} jest najwieksza liczba", b);
                }
                else
                {
                    if (c >= a && c >= b)
                    {
                        Console.WriteLine("{0} jest najwieksza liczba", c);
                    }
                }
            }

        }
    }
}
