/* Jaką wartość przyjmą zmienne użyte w programie po wykonaniu poniższych instrukcji? 
Najpierw ustal wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
a)
int x = 1, y = 4, z = 2;
bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);  // wynik = false, bo pierwszy warunek  z lewej niespelniony, bo x jako 1 nie jest wieksze od 1,
//wiec reszty warunkow nie sprawdzi juz

Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
b)
int x = 1, y = 4, z = 2;
bool wynik = (x++ > 1 & y++ == 4 && z-- > 0); //wynik false, bo pierwszy warunek
//niespelniony, ale zmienia sie wartosci zmiennych, bo przy koniunkcji bezwarunkowej, mimo ze pierwszy warunek nie jest spelniony, to sprawdza program jeszcze drugi
// Po wykonaniu sie wyrazenia x = 2, y =5, z = 2
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
c)
int x = 1, y = 4, z = 2;
bool wynik = (x++ > 1 & y++ == 4 & z-- > 0); // wynik = false, bo juz pierwszy warunek niespelniony, ale reszte i tak sprawdzi program i na koncu po wykonaniu wyrazenia 
//odpowiednio zmieni wartosc zmiennych z dopiskiem inkrementacji , wynik=False x=2 y=5 z=1
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
d)
int x = 1, y = 3, z = 4;
bool wynik = (x == 1 || y++ > 2 || ++z > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
// Tutaj wynik=True x=1 y=3 z=4, bo program najpierw sprawdzy przy tej alternatywie warunkowej czy jest pierwsyz warunek spelniony- jak tak, bo nastepnych nawte nie sprawdza
//(a co za tym idzie nie aktualizauje tez wartosci
e)
int x = 1, y = 3, z = 4;
bool wynik = (x == 1 | y++ > 2 || ++z > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
//Tu z kolei wynik=True x=1 y=4 z=4, bo pierwsze te alternatywa bezwarunkowa i mimo, ze pierwszy warunek spelniony zostal, to i tak sprawdza nastepne i aktualizuje
f)
int x = 1, y = 3, z = 4;
bool wynik = (x == 1 | y++ > 2 | ++z > 0);
Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
//Tutaj wynik=True x=1 y=4 z=5, bo same alternatywy bezwarunkowe i wszystkie warunki zostana sprawdzone, a zmienne zaktualizowane, inkrementacje wykonaja sie dopiero
//po wykonaniu wyrazenia

*/

using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0); // 
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.ReadKey();
        }
    }
}
//etc.
//Urszula B.
