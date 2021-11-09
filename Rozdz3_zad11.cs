/*Zadanie 3.11. 
Napisz program obliczający, ile kolejnych liczb całkowitych (rozpoczynając od wartości 
1) należy dodać do siebie, aby suma przekroczyła wartość 100.
 */


using System;

namespace rozdzial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; suma >= 0; i++){
                suma += i;
                Console.WriteLine("suma = {0}", suma);
                if (suma > 100 && suma < 110)
                {
                    Console.WriteLine("Suma przekroczyla 100");
                    break;
                }
                else continue;
            }
        }    
    }
}
//Urszula B.
