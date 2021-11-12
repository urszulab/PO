/*Zadanie 4.14.
W danej firmie środki trwałe mają identyfikatory złożone z kilku liter, myślnika oraz 
czterech cyfr. Te cztery cyfry to rok zakupu danego środka trwałego. Przykładowe 
identyfikatory to: KOMG-2002, BH-2010. Napisz program, który deklaruje 5-cio elementową 
tablicę typu string dla środków trwałych, którą należy zainicjalizować przykładowymi 
identyfikatorami w czasie deklaracji. Program ma dla każdego środka trwałego podać liczbę 
lat, jakie upłynęły od jego zakupu.
 */

using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            int rok = 2021;
            string[] tab = { "KOMG-2002", "BH-2010", "UB-1997", "AK-2008", "DB-1968" };
            int rok_1 = Convert.ToInt32(tab[0].Substring(5, 4));
            int rok_2 = Convert.ToInt32(tab[1].Substring(3,4));
            int rok_3 = Convert.ToInt32(tab[2].Substring(3, 4));
            int rok_4 = Convert.ToInt32(tab[3].Substring(3, 4));
            int rok_5 = Convert.ToInt32(tab[4].Substring(3, 4));

            int roznica1 = rok - rok_1;
            int roznica2 = rok - rok_2;
            int roznica3 = rok - rok_3;
            int roznica4 = rok - rok_4;
            int roznica5 = rok - rok_5;

            Console.WriteLine("Dla {0} uplynelo {1}", tab[0], roznica1);
            Console.WriteLine("Dla {0} uplynelo {1}", tab[1], roznica2);
            Console.WriteLine("Dla {0} uplynelo {1}", tab[2], roznica3);
            Console.WriteLine("Dla {0} uplynelo {1}", tab[3], roznica4);
            Console.WriteLine("Dla {0} uplynelo {1}", tab[4], roznica5);
        }        
    }
}
//Urszula B.
