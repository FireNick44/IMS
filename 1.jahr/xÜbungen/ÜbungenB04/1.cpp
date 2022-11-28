#include<math.h>
#include<stdio.h>
#include<stdlib.h>

void main()
{
  double zahl1, zahl2;
  printf("Geben Sie eine Zahl ein: ");
  scanf_s("%lf", &zahl1);
  zahl2 = sqrt(zahl1);
  zahl1 *= 10;
  printf("Die Quadratwurzel ist %8.2lf\n", zahl2);
  printf("Die eingegebene Zahl mal 10 ist %lg\n",zahl1 );
  system("pause");
}