using System;
namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza");
            C = double.Parse(Console.ReadLine()); 
            F = 32 + (9d / 5) * C;
            Console.WriteLine(F);
            Console.ReadKey(); 
        }
    }
}

//Urszula B.
