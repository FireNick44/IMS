#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int zahl = 1;
  do
  {
    printf("Geben Sie eine positive Zahl ein, eine negative Zahl beendet das programm");
    scanf_s("%i",&zahl);
  } while (zahl >= 0);
  printf("Sie habe n iene negative Zahl eingegeben.");
  system("pause");
  return 0;
}