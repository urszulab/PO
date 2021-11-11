/*Zadanie 4.1. 
Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb 
całkowitych wartościami podanymi przez użytkownika. Na początku działania programu 
użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej 
elementów. Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli
 */

using System;

namespace rozdzial4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wielkosc tablicy: ");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] tab = new int[rozmiar];
            
            for (int i =0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj wartosc {0}", i + 1);
                int wartosc = Convert.ToInt32(Console.ReadLine());
                tab[i] = wartosc; 
            }
            for (int j = 0; j<tab.Length; j++)
            {
                Console.WriteLine("Element {0} to {1}", j+1, tab[j]);
            }

        }
    }
}
//Urszula B.
