#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main()
{
  float x;
  printf("Geben Sie eine Zahl von 0 bis 1000000 ein von der Sie die Wurzel ziehen möchten\n\n\n");
  scanf_s("%f", &x);

  if (x >= 0 || x <= 1000000)
  {
    x = sqrt(x);
    printf("Das Ergebniss ist: %.2f\n\n\n", x);
  }

  else
  {
    printf("Sie haben eine falsche Zahl eingegeben\n\n\n");
  }

  system("pause");
  return 0;
}