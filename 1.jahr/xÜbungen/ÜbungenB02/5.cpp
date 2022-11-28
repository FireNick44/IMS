#include<stdio.h>
#include<stdlib.h>

int main()
{
  float x = 0;
  printf("Geben sie die zu halbierende Zahl ein: ");
  scanf_s("%f", &x);
  x = x / 2;
  printf("Die H\x84lfte der eingegebenen Zahl ist %g\n", x);
  system("pause");
  return 0;
}