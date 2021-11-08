/*Napisz program pobierający od użytkownika liczby całkowite. Program ma pobierać te 
liczby do czasu, gdy użytkownik wprowadzi wartość 0 (zero). Wynikiem działania programu 
ma być informacja o sumie wprowadzonych przez użytkownika liczb.

 */

using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int warunek = 0;
            int suma = 0;
            while (warunek == 0)
            {
                Console.WriteLine(" Wpisz liczbe calkowita:");
                int liczba = int.Parse(Console.ReadLine());
                if (liczba != 0)
                {
                    suma += liczba;
                    Console.WriteLine("Suma wynosi: {0}", suma);
                }
                else
                {
                    Console.WriteLine("Po podaniu cyfry 0 program przerywa dzialanie");
                    break;         
                }
            }
        }
    }
}
//Urszula B.
