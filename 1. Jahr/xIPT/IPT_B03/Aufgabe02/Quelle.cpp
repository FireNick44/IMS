#include<stdlib.h>
#include<stdio.h>

void main()
{
  int zahl;
  printf("Geben Sie eine vierstellige Zahl ein: ");
  scanf_s("%i", &zahl);
  zahl = zahl / 1000;
  printf("Die erste Ziffer der Zahl ist %i\n", zahl);
  system("pause");
}