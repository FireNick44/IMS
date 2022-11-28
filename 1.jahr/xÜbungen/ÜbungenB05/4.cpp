#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main()
{
  float x, y;
  printf("Geben Sie eine Zahl ein:\n");
  scanf_s("%f", &x);
  printf("Geben Sie eine Potenz ein womit Sie die Zahl multiplizieren:\n");
  scanf_s("%f", &y);

  if (x <= 100)
  {
    x = pow(x, y);
    printf("Das Ergebniss ist: %.0f\n\n\n", x);
  }

  else
  {
    printf("Sie haben eine falsche Zahl eingegeben\n\n\n");
  }

  system("pause");
  return 0;
}