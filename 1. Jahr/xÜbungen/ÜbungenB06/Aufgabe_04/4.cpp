#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  float x;
  do
  {
    printf("Geben Sie eine Zahl ohne kommastelle ein.\n");
    scanf_s("%f",&x);
  } while ((int)x == x);

  printf("Sie haben eine Zahl mit einer kommastelle eingegeben.\n");
  system("pause");
  return 0;
}