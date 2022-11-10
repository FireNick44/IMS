#include <stdio.h>
#include <stdlib.h>

int main()
{
  //Variable 
  int Länge = 0;
  int Breite = 0;
  int Fläche = 0;

  //Referenzen / Adressen 
  int* pLänge = &Länge;
  int* pBreite = &Breite;
  int* pFläche = &Fläche;

  //Eingabe von länge und Breite 
  printf("Geben Sie die Laenge und Breite ein: \n");
  printf("B:");
  scanf_s("%i", pBreite);
  printf("L:");
  scanf_s("%i", pLänge);

  //Verarbeitung der Eingabe, berechnung der Fläche 
  *pFläche = *pLänge * *pBreite;
  
  //Ausgabe von Länge, Breite und Fläche
  printf("Die Flaeche ist %i\n\n\n",*pFläche);

  system("pause");
  return 0;
}
