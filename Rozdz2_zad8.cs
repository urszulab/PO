/* Po wykonaniu poniższych linii programu: 
bool x;
 int y = 1, z = 1;     
 x = (y == 1 && z++ == 1);  // 
zmienne przyjmą wartości: 
a) x=true, y=1, z=2   b) x=1, y=1, z=2
c) x=true, y=1, z=1   d) x=2, y=1, z=2.

ODP: a -  koniunkcja warunkowa - sprawdza czy pierwsyz ok, jak tak, to potem drugi warunek. Tutaj pierwszy jest spelniony, drugi tez, bo 
przy sprawdzaniu warunku z ==1, a dopiero na koncu po wykonaniu sie wyrazenia calego z bedzie wieksze o 1, wiec finalnie x jako zmienna boolowska da albo true albo false, 
ale jako ze oba warunki spelnione to  x = true, y =1, z=2

*/

