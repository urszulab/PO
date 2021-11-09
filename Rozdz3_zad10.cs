/*Zadanie 3.10.
Napisz program obliczający n! (n silnia), gdzie n jest podane przez użytkownika.
 */


using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine(" Podaj n: ");
            n = double.Parse(Console.ReadLine());
            int silnia = 1;
            for(int i=1; i<= n; i++)
            {
                silnia *= i;
            }
            Console.WriteLine(" Wynik silni {0}! = {1}", n, silnia);         
        }  
    }
}
//Urszula B.
