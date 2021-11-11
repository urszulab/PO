/* Zadanie 4.2. 
Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
wyłącznie wartości dodatnie. Obie tablice mają być jednowymiarowe o rozmiarze równym 10 
(czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) należy wpisać w trakcie deklaracji 
tej tablicy.  */


using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            int[] a = { 5, -7, 24, 13, -77, 4, 3, 2, -65, 18 };
            int[] b = new int[10];
            int licznik = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[licznik] = a[i];
                    licznik++;
                }
            }

            Console.Write(string.Join(", ", b));
        }
    }
}
//Urszula B.
