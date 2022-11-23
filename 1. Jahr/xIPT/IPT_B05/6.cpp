#include <stdio.h>
#include <stdlib.h>

int main()
{
  int Betrag, Resultat;
  printf("\nBitte Betrag eingeben:\t\t");
  scanf_s("%d", &Betrag);
  printf("\nBitte Resultat eingeben:\t");
  scanf_s("%d", &Resultat);

  if (Betrag != Resultat)
  {
    printf("\nBetrag und Resultat sind nicht gleich gross.\n");
  }
  else
    printf("\nBetrag und Resultat sind gleichwertig.\n");

  system("pause");
  return 0;
}