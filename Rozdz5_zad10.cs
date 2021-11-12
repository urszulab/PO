/*Zadanie 5.10.
Jaki będzie rezultat metody Oblicz() wywołanej z parametrem n = 5? Zadanie wykonaj 
najpierw bez udziału kompilatora, a dopiero później uruchom program i sprawdź otrzymany 
wynik.
 */
using System;


namespace rozdzial5
{
    class Program
    {
        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }

        static void Main(string[] args)
        {
            int a = Oblicz(5);
            Console.WriteLine(" Wynik to ={0}", a);
            Console.ReadKey();
        }
    }
}
//Urszula B.
