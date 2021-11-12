/*Zadanie 5.1. 
Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach 
Fahrenheita na temperaturę w stopniach Celsjusza. Metoda ma przyjmować jeden argument 
(temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza.
 */

using System;


namespace rozdzial5
{
    class Program
    {
        static double Zamiana(double a)
        {
            double wynik = (5d / 9) * (a - 32);
            return wynik;
        }
        static void Main(string[] args)
        {
            double F;
            Console.WriteLine("Podaj temp. w stopniach Fahrenheita");
            F = double.Parse(Console.ReadLine());
            Console.WriteLine("Wynik to w st.Celsjusza = {0:F2}", Zamiana(F));
            Console.ReadKey();
        }
    }
}
