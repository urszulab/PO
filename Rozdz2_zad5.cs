/* Po wykonaniu poniższych linii programu:
int x = 2, y = 3;
 x *= y * 2; */
 
 
 using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 3;
            x *= y * 2;    // to jest to samo co:  x = x * y * 2  , gdzie przypisywanie wartosci jest od prawej do lewej
            Console.WriteLine(" x={0}", x);
        }
    }
}

//Urszula B.
