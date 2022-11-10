#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int y,x;

  printf("Geben Sie zwei Zahlen ein:\n");

  printf("Zahl 1:\t");
  scanf_s("%i", &x);
  printf("Zahl 2:\t");
  scanf_s("%i", &y);

  if (x > 100 && x > y) { // Es muss beides sein.
    printf("\n%i ist gr\x94sser als 100 und %i\n", x, y);
  }

  else if (x == y) { //mach am meisten Sinn bei dieser Ausführung
    printf("\n Sie haben die gleichen Zahlen eingegeben\n");
  }

  else {
    printf("\n %i ist kleiner als 100 oder %i\n", x, y);
  }

  system("pause");
  return 0;
}