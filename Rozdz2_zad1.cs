using System;
namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza");//WriteLine() - printf
            C = double.Parse(Console.ReadLine()); //ReadLine - scanf()
                                                      //ReadLine();  wczytuje stringi, ale ze potrzebujemy liczby
                                                      //TO METODA   double.Parse() zamieni na typ double
            F = 32 + (9d / 5) * C;
            Console.WriteLine(F);
            Console.ReadKey();
           
        }
    }
}

//Urszula B.
