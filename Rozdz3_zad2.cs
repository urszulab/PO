/* Zadanie 3.2.
Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien 
wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej */

using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Podaj liczbe calkowita a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe calkowita b: ");
            b = int.Parse(Console.ReadLine());
            if (a % b == 0){
                Console.WriteLine("{0} jest dzielnikiem liczby {1}", b, a);
            }
            else{
                if (b % a == 0) {
                    Console.WriteLine("{0} jest dzielnikiem liczby {1}", a, b);
                }
                else Console.WriteLine("Nie jest dzielnikiem");
            }
               
        }
    }
}
// Urszula B.
