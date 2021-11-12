/*Zadanie 4.9. 
Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez 
użytkownika. Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.
 */
      
using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Napisz zdanie: ");
            string zdanie = Console.ReadLine();
            int i = 0;
            int licznik = 0;
            while (i <= zdanie.Length-1)
            {
                if (zdanie[i] == ' ' || zdanie[i] == '\n' || zdanie[i] == '\t')
                {
                    licznik++;
                }
                i++;
            }
            Console.WriteLine("Ilosc wszystkich wyrazow = " + (licznik+1));
            Console.ReadLine();
        }
    }
}
//Urszula B.
