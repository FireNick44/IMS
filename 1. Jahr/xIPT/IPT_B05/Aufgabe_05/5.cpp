#include <stdio.h>
#include <stdlib.h>

int main()
{
  int Wert, Zahl;
  printf("\nBitte Wert eingeben:\t\t");
  scanf_s("%i", &Wert);
  printf("\nBitte Zahl eingeben:\t\t");
  scanf_s("%i", &Zahl);
  if (Wert == Zahl)
    printf("\nDie beiden Zahlen sind gleich gross.");
  else if (Wert > Zahl)
    printf("\nDer Wert %i ist groesser.\n", Wert);
  else
    printf("\nDer Wert %i ist kleiner als die Zahl %i.\n", Wert , Zahl);
  system("pause");
  return 0;
}