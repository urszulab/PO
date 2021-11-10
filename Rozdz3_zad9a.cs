/*Zadanie 3.9 a) . 
Napisz program wyswietlajacy :
 
*
**
***
****    

 */

using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbe wierszy: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) // wiersz   
            {
                for (int j = 1; j <= i; j++) //kolumna
                {
                    if (j<=i) Console.Write("*"); 
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }    
    }
}
//Urszula B.
