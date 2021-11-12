/*Zadanie 4.13. 
Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego 
występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy 
idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się 
idzie – odpowiedział Puchatek” – program powinien wypisać raport o słowach powielonych 
w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy. 
 */

using System;
using System.Text.RegularExpressions; // dla klasy Regex

namespace rozdzial4
{
    class Program
    {
        public static void Main()
        {
            string tekst = "Ewa nazywa sie Kowalska. Jej siostra nazywa sie Ewelina Kowalska. Matka Kowalska jest wiekowa. Jej brat z kolei jest emerytowanym zolnierzem.";
            int licznik1 = 0;
            foreach (Match m in Regex.Matches(tekst, "nazywa sie"))
            {
                licznik1++;
            }
            int licznik2 = 0;
            foreach (Match n in Regex.Matches(tekst, "Kowalska"))
            {
                licznik2++;
            }
            int licznik3 = 0;
            foreach (Match i in Regex.Matches(tekst, "Jej"))
            {
                licznik3++;
            }
            int licznik4 = 0;
            foreach (Match j in Regex.Matches(tekst, "jest"))
            {
                licznik4++;
            }
            Console.WriteLine("W teksie slowo \"nazywa sie\" wystapilo {0} razy, \"Kowalska\" {1} razy, \"Jej\" {2} razy, \"jest\" {2} razy. ", licznik1, licznik2, licznik3, licznik4);
        }
    }
}
//Urszula B.
