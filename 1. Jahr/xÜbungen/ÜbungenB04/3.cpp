#include<stdlib.h>
#include<stdio.h>
#include<math.h>

void main()
{
  float a, b;
  printf("Geben Sie die L\x84nge des Rechtecks ein: ");
  scanf_s("%f", &a);
  printf("Geben Sie die Breite des Rechtecks ein: ");
  scanf_s("%f", &b);
  a = sqrt(a*a+b*b);
  printf("Die Diagonale ist %f Einheiten lang\n", a);
  system("pause");
}