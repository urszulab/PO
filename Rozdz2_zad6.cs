/* Jaką wartość będzie miała zmienna x po wykonaniu poniższych instrukcji? Najpierw 
oblicz wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program. 
int x, y = 4;
x = (y -= 2);   //  x = ( y = y - 2) , gdzie     2  = (  2 =  4 - 2)
x = y++;   // tu y wchodzi stare, czyli 2, x to wciaz 2
x = y--;   // tu x o jeden wieksze, czyli 3, bo y sie zwiekszyl o 1 po wczesniej postinkrementacji

// na koncu x to 3, a y to 2


*/

using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(" x={0}, y={1}", x, y);
            Console.ReadKey();
        }
    }
}

//Urszula B.

