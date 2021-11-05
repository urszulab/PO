/* Napisz program, który oblicza deltę dla równania kwadratowego ax^2 +bx + c = 0 
Program ma prosić użytkownika o podanie współczynników równania a, b oraz c. Wzór: delta = b^2 - 4ac. */

using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liczby typu double to z przecinkiem, nie z kropka np. 2,5   nie 2.5
            double a, b, c, x, x1, x2;
            Console.WriteLine("Podaj wspolczynnik a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            c = double.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            double dzielnik = 2 * a;
            if (delta>0 && dzielnik !=0){
                x1 = (-b - Math.Sqrt(delta)) / dzielnik;
                x2 = (-b + Math.Sqrt(delta)) / dzielnik;
                Console.WriteLine("x1={0}, y={1}", x1, x2);
            } 
            else if (delta<0 || dzielnik ==0 ){
                if (delta < 0){
                    Console.WriteLine("Brak rozwiazania");
                }
                else Console.WriteLine("Zakaz dzielenia przez 0");      
            }
            else{
                x = -b / dzielnik;
                Console.WriteLine(" x={0}", x);


            }
        }
    }
}

//Urszula B.
