/* Co wyświetli się na ekranie po wykonaniu poniższych instrukcji. Najpierw oblicz 
wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
int x, y = 5;
x = ++y * 2;   
x = y++;   
x = y--;     
Console.WriteLine(++y);  */


using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y * 2;   // x =12, y = 6
            x = y++;  // x = 6,  po wykonaniu wyrazenia y = 7
            x = y--; // x = 7,  po wykonaniu wyrazenia y =6
            Console.WriteLine(++y); // przed wyswietleniem zwiekszenie o 1 y, wiec y=7 po wyswietleniu, bo preinkrementacja

            Console.ReadKey();
        }
    }
}

//Urszula B.
