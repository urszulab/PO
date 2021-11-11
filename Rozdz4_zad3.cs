/* Zadanie 4.3. 
Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy n elementowej:
 wartość i numer pozycji największego elementu,
 wartość i numer pozycji najmniejszego elementu,
 średnia wartości wszystkich elementów tablicy,
 liczba dodatnich elementów tablicy.
 */

    using System;

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Podaj rozmiar tablicy ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartosc {0}", i + 1);
                int wartosc = Convert.ToInt32(Console.ReadLine());
                tab[i] = wartosc;
                suma += tab[i];
            }
            //MAXIMUM
            int max = tab[0];
            int pozycja_max = 0;
            for (int j = 0; j < tab.Length-1; j++)
            {
                if (tab[j + 1] > max)
                {
                    max = tab[j + 1];
                    pozycja_max = j + 1; 
                }  
            }
            Console.WriteLine("Max wartosc to {0}, a nr indeksu to {1}", max, pozycja_max);

            //MINIMUM
            int min = tab[0];
            int pozycja_min = 0;
            for (int m = 0; m < tab.Length - 1; m++)
            {
                if (tab[m + 1]  < min)      //jesli b< a to b to min
                {
                    min = tab[m + 1];
                    pozycja_min = m + 1;
                }
            }
            Console.WriteLine("Min wartosc to {0}, a nr indeksu to {1}", min, pozycja_min);
            //SREDNIA WARTOSCI
            Console.WriteLine(" Suma to: {0}", (Convert.ToDouble(suma)/ n));

            //LICZBA DODATNICH ELEMENTOW
            int licznik = 0;
            for (int k = 0; k < tab.Length; k++)
            {
                if (tab[k] > 0)
                {
                    licznik++;
                }
            }
            Console.WriteLine("Ilosc dodatnich elementow  = {0}", licznik);
        }
    }
}
//Urszula B.
