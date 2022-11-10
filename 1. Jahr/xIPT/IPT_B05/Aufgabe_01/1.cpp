#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int zahl1, zahl2;

  printf("Geben Sie zwei Zahlen ein:\n");

  printf("Zahl 1:\t");
  scanf_s("%i", &zahl1);
  printf("Zahl 2:\t");
  scanf_s("%i", &zahl2);

  if (zahl1 < zahl2){
    printf("\n%i ist gr\x94sser als %i\n", zahl2, zahl1);
  }
  else if (zahl1 > zahl2) {
    printf("\n%i ist gr\x94sser als %i\n", zahl1, zahl2);
  }
  else {
    printf("\nFalsche Eingabe\n\n\n");
  }


  system("pause");
  return 0;
}