#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int y;
  float x;

  printf("\nBitte geben Sie eine ganzzahlige Note zwischen 1 und 6 ein:\n");
  printf("Note:\t");
  scanf_s("%f", &x);

  if ((int)x == x) {
    y = x;

    if (y == 1) {
      printf("Note 1 ist sehr schwach!\n\n\n");
    }
    else if (y == 2) {
      printf("Note 2 ist schwach!\n\n\n");
    }
    else if (y == 3) {
      printf("Note 3 ist ungen\x81gend!\n\n\n");
    }
    else if (y == 4) {
      printf("Note 4 ist gen\x81gend!\n\n\n");
    }
    else if (y == 5) {
      printf("Note 5 ist gut!\n\n\n");
    }
    else if (y == 6) {
      printf("Note 6 ist ausgezeichnet!\n\n\n");
    }
  }
  else {
    printf("Sie haben eine falsche Zahl eingegeben.\n\n\n");
  }

  system("pause");
  return 0;

}