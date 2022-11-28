#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  //Variable
  double Quadrat = 81.0;

  //Referenzen / Adressen
  double* pQuadrat = &Quadrat;

  printf("Quadrat = %.2lf\n", *pQuadrat);
  printf("Zahl    = %.2lf\n", sqrt(*pQuadrat));

  system("pause");
  return 0;
}
