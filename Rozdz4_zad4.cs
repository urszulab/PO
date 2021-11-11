/*Zadanie 4.4. 
Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu 
int. Tablicę należy wypełnić losowymi wartościami. Wskazówka: Poniższy fragment 
programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych) –
w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie 
decydują argumenty podane w wywołaniu metody Next()43). 
Random rand = new Random();
for (int i = 0; i < 100; i++)
 Console.Write("{0,8}", rand.Next(1, 1000));

 */

using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            int[] tab = new int[100];
            Random liczba = new Random();
            for (int m = 0; m < 100; m++)
            {
                tab[m] = liczba.Next(1, 1000);  // PRZYPISANIE KAZDEJ NOWO WYLOSOWANEJ LICZBY Z PRZEDZIALU 1-1000 DO DANEGO MIEJSCA W TABLICY
            }
                //SPRAWDZANIE CZY LICZBA PIERWSZA;
            for (int i = 0; i <= tab.Length - 1; i++)
            {
                int licznik = 0;
                for (int k = 1; k <= Math.Sqrt(tab[i]); k++)
                {
                    if (tab[i] % k == 0)
                    {
                        licznik++;
                    }

                }
                if (licznik == 1)
                {
                    Console.WriteLine("{0} jest liczba pierwsza.", tab[i]);
                }
            }
        }
    }
}
//Urszula B.
