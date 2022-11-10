#include<stdio.h>
#include<stdlib.h>

void main()
{
  int a, b;
  float c;
  scanf_s("%i%i", &a, &b);
  c = a / (float)b;
  printf("res = %10.2f\n", c);
  system("pause");
}