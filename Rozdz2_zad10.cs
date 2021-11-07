/* Po wykonaniu przedstawionego niżej kodu programu zmienna gestoscZaludnienia
przyjmie wartość 0. Odpowiedz dlaczego i zmień program (w linii, gdzie jest obliczana 
zmienna gestoscZaludnienia) tak, aby wartość tej zmiennej wynosiła 0,1 (czyli 10/100):
int powierzchnia = 100, osoby = 10;
double gestoscZaludnienia = osoby/powierzchnia;
Console.WriteLine(gestoscZaludnienia);
 */
 

using System;

namespace Praca_dom1
{
    class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (osoby /Convert.ToDouble(powierzchnia)); // bo jak sie podzieli inty, to utnie koncowke, trzeba przerzutowac z inta na double'a
            Console.WriteLine("Gestosc zaludnienia = {0:F1}", gestoscZaludnienia);  // F1 zaweza do 1 miejsca po przecinku
            Console.ReadKey();
        }
    }
}

//Urszula B.
