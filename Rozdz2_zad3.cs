/* Napisz program, który oblicza wskaźnik masy ciała BMI. Program ma prosić 
użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach. Wzór: BMI = masa/wzrost*2  */

using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI, wzrost, masa;
            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj mase w kg: ");
            masa = double.Parse(Console.ReadLine());

            BMI = masa / (wzrost * 2);
            Console.WriteLine(" BMI wynosi {0:F2}", BMI); // :F2 zaokragli do 2 miejsc po przecinku
            Console.ReadKey();
        }
        
    }
}
//Urszula B.


