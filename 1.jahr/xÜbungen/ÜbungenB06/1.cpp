#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  system("color a");
  int x, eingabe;
  printf("Geben Sie eine positive Ganzzahl ein:");
  scanf_s("%i",&eingabe);
  for (x=1; x<=eingabe; x+=2) //for (Startwert; Bedingung; Zähler)
  {
    printf("\n Zahl %i",x);
    system("color fa");
    system("color a7");
    system("color 1c");
    system("color e6");
    system("color 79");
    system("color de");

  }
system("pause");
return 0;
}