/*Zadanie 4.6. 
Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb 
rzeczywistych o rozmiarze 5 x 5. Program ma wyświetlić elementy tablicy (wiersz po 
wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej 
tablicy (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).


 */

using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            int[,] tab = new int[,] { { 5, 7, 1 ,13, 18 },
                                      {14, 11, 6, -3, 2 },
                                      {-28, 28, 19, 88, 99 },
                                      {15, 33, 22, 10, 86 },
                                      {17, 25, 45, 75, 35 } };
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Console.Write("{0,3}", tab[a, b]);
                }
                Console.WriteLine();
            }
            int suma = 0;
            for (int i = 0; i <5; i++)
            {                                  
                for (int j = 0; j<5; j++)
                {  
                    if (i==j)
                    {
                        suma = suma + tab[i, j];
                    } 
                }
            }
            Console.Write("Suma tych elementow wynosi  :{0}\n", suma);
            Console.ReadKey();
        }
    }
}
//Urszula B.
