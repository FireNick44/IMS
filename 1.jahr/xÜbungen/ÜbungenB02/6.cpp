#include<stdio.h>
#include<stdlib.h>

void main()
{
  float x = 0;
  printf("Geben sie eine Zahl ein: ");
  scanf_s("%f", &x);
  x = (float)x + x;
  printf("Das Doppelte Ihrer eingegebenen Zahl ist %g\n", x);
  system("pause");
}