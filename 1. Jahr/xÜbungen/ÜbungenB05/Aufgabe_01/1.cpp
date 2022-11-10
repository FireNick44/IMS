#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int y;
  float x;

  printf("\nBitte geben Sie eine ganze Zahl von 1 bis 3 ein: ");
  scanf_s("%f", &x);

  if ((int)x == x) {
    y = x;

    if (y == 1) {
      printf("Sie haben 1 eingegeben\n\n\n");
    }

    else if (y == 2) {
      printf("Sie haben 2 eingegeben\n\n\n");
    }

    else if (y == 3) {
      printf("Sie haben 3 eingegeben\n\n\n");
    }
  }


  else {
    printf("Sie haben eine falsche Zahl eingegeben.\n\n\n");
  }

  system("pause");
  return 0;

}