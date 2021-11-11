/*Zadanie 4.6. 
Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb 
rzeczywistych o rozmiarze 5 x 5. Program ma wyświetlić elementy tablicy (wiersz po 
wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej 
tablicy (główna przekątna – od elementu o indeksach 0,0 do elementu o indeksach n,n).


 */

//gdzies tu dodaje 4 zbedne... !!

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

            //int[,] tablica2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Console.Write("{0,3}", tab[a, b]);
                }
                Console.WriteLine();
            }
            int m = 5;
            int suma = 0;
            for (int i = 0; i <5; i++)
            {                                  
                m = m -1;
                for (int j = 0; j<5; j++)
                {
                    
                    if (j == m)
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
