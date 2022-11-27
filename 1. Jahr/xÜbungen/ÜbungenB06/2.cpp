#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
 
   int zahl = 1;
   while (zahl >= 0 && zahl <=100)
   {
     printf("\nBitte eine Zahl eingeben");
     printf("\n(eine Zahl kleiner als 0 oder gr\x94er 100 f\x81r zum Abbruch)");
     scanf_s(" %i",&zahl);
   }
   printf("\nProgramm wurde beendet\n");

  system("pause");
  return 0;
}