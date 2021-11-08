/* Zadanie 3.6. 
Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić 
użytkownika o podanie wagi w kg oraz wzrostu w metrach. Wzór: 
2 wzrost
masa BMI
(treść 
zadania 2.3). 
a) Po obliczeniu wskaźnika BMI program powinien wyświetlać stosowną informację w 
zależności od wartości wskaźnika:
 < 18,5 – niedowaga,
 18,5–24,99 – wartość prawidłowa,
 ≥ 25,0 – nadwaga.
 */

using System;

namespace Praca_dom1
{
    class Program
    {
        public const double pierwszy_prog = 18.5 ;
        public const double drugi_prog_najnizsza = 18.5;
        public const double drugi_prog_najwyzsza = 24.99;

        static void Main(string[] args)
        {
            double BMI, wzrost, masa;
            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj mase w kg: ");
            masa = double.Parse(Console.ReadLine());

            BMI = masa / (wzrost * 2);
            Console.WriteLine(" BMI wynosi {0:F2}", BMI); // :F2 zaokragli do 2 miejsc po przecinku
            if (BMI < pierwszy_prog)
            {
                Console.WriteLine("Jest to niedowaga");
            }
            else if (drugi_prog_najnizsza <= BMI && BMI <= drugi_prog_najwyzsza)
            {
                Console.WriteLine("Prawidlowa wartosc wagi");
            }
            else Console.WriteLine("Jest to nadwaga");
            Console.ReadKey();
        }

    }
}
//Urszula B.
