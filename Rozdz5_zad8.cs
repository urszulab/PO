/*Zadanie 5.8.
Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym 
wywołaj funkcję dla x wczytanego z klawiatury. Przykładowo jeśli użytkownik wpisze 125, 
to metoda powinna zwrócić wartość 8 (1+2+5=8).
 */

using System;


namespace rozdzial5
{
    class Program
    {
        static double SumaCyfr(string liczba)
        {
            double cyfra_1 = Char.GetNumericValue(liczba,0);   // metoda, ktora bierze stringa(liczba tutaj zmienna) i po przecinku ktora pozycja, potem zamienia to na liczbe
            double cyfra_2 = Char.GetNumericValue(liczba, 1);
            double cyfra_3 = Char.GetNumericValue(liczba, 2);
            double suma = cyfra_1 + cyfra_2 + cyfra_3;
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe calkowita: ");
            string x = Console.ReadLine();
            Console.WriteLine("Suma cyfr = {0}", SumaCyfr(x));  
            Console.ReadKey();
        }
    }
}
