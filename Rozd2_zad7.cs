/* Co wyświetli się na ekranie po wykonaniu poniższych instrukcji. Najpierw oblicz 
wartości zmiennych, a dopiero później sprawdź wynik uruchamiając program.
int x, y = 5;
x = ++y * 2;    // tu x to 12, bo preinkrementacja
x = y++;    // tu x to 12 wciaz
x = y--;      // tu x to 13, ale po wykonaniu insturkcji y to 12
Console.WriteLine(++y);  */
// ostatecznie x to 13, a y to 12, ale po wyswietleniu y bedzie o jeden wiekszy
