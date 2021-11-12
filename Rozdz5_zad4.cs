/* Zadanie 5.1. 
Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę. 
Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu 
int oraz liczbę całkowitą (mnożnik). 
Wykonaj zadanie w dwóch wariantach: 
a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona 
przez metodę. */

using System;

namespace rozdzial4
{
    class Program
    {

        static int[] Mnozenie(int[] tablica, int liczba)
        { 
             
                int[] nowa = new int[tablica.Length]; 
                for (int i = 0; i < tablica.Length; i++)
                    nowa[i] = tablica[i] * liczba;
                return nowa;
        }
        static void Main(string[] args)
        {
            int[] tab = { 2, 5, 7, 12, 8 };
            int liczba = 3;
            for (int j = 0; j < tab.Length; j++)
            {
                Console.Write("{0} ", tab[j]);
            }
            Console.WriteLine("A teraz tablica z metody: ");
            int[] tab2 = Mnozenie(tab, liczba);
            for (int j = 0; j < tab2.Length; j++)
            {
                Console.Write("{0} ", tab2[j]);
            }
        }
    }
}
