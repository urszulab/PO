/* Zadanie 3.1.
Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok 
przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100 (za wyjątkiem lat podzielnych 
przez 400). */

using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj rok: ");
            rok = int.Parse(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0){
                Console.WriteLine(" Rok jest przestepny");
            }
            else Console.WriteLine("Rok nie jest przestepny");
            Console.ReadKey();
        }
    }
}
//Urszula B.
