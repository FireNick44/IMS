#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  float x;
  do 
  {
   printf("Geben Sie eine positive Zahl ein, von der Sie die Wurzel wissen m\x84chten");
   scanf_s("%f",&x);
   x = sqrt(x);
  } while (x >= 0);
  printf("Sie haben einen ung\x81ltigen Wert eingegeben.");
  system("pause");
  return 0;

}