#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <cstdlib>
#include <time.h>

int main()
{
  int v1 = 5; //(-32760 - +32760 Nur Zahlen)
  //char v2 = 'D'; //Alle zeichen 0123, ABCD, /%*"
  float v3 = 5; // Zahlen mit Kommas

  v1 = v1 / 4; //int
  v3 = v3 / 4; //float

  printf("%i\n", v1);
  printf("%f\n", v3);


  system("pause");
  return 0;
}