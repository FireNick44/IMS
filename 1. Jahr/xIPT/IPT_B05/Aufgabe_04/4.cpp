#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int y, x;

  printf("Geben Sie zwei Zahlen ein:\n");

  printf("X:\t");
  scanf_s("%i", &x);
  printf("Y:\t");
  scanf_s("%i", &y);

  if (x > 100 || x > y) { //      || = oder 
    printf("\n You are a Winner\n");
  }

  else if (x == y) { //mach am meisten Sinn bei dieser Ausführung
    printf("\n Sie haben die gleichen Zahlen eingegeben\n");
  }

  else {
    printf("\n You are a Loser\n");
  }

  system("pause");
  return 0;
}