/*Zadanie 4.12.
Napisz program, który dla zadeklarowanej niżej zmiennej łańcuchowej wyświetli jej 
zawartość, poda liczbę wierszy oraz poda liczbę znaków w każdym wierszu.
// fragment powieści A. A. Milne, "Kubuś Puchatek"
string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
 "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
 "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
 "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
 "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł."
 */

using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            Console.Write(tekst);
            Console.WriteLine();
            Console.WriteLine();
            int i = 0;
            int wiersze = 0;
            while ( i<= tekst.Length-1)
            {
                if (tekst[i] == '\n')
                {
                    wiersze++;
                }
                i++;
            }
            Console.WriteLine("Ilosc wierszy {0}",  wiersze+1);       
        }
    }
}
