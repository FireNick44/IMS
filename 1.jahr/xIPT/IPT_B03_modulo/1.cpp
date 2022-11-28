#include<stdlib.h>
#include<stdio.h>
#include<math.h>

void main()
{
  int zahl;
  printf("Geben Sie eine Zahl ein: ");
  scanf_s("%i", &zahl);
  zahl = zahl % 10;
  printf("Die letzte Stelle der Zahl ist %i\n", zahl);
  system("pause");

}