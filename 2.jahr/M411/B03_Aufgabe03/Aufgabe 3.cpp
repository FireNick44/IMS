#include <stdio.h>
#include <stdlib.h>

int main()
{
  //Variable 
  int L�nge = 0;
  int Breite = 0;
  int Fl�che = 0;

  //Referenzen / Adressen 
  int* pL�nge = &L�nge;
  int* pBreite = &Breite;
  int* pFl�che = &Fl�che;

  //Eingabe von l�nge und Breite 
  printf("Geben Sie die Laenge und Breite ein: \n");
  printf("B:");
  scanf_s("%i", pBreite);
  printf("L:");
  scanf_s("%i", pL�nge);

  //Verarbeitung der Eingabe, berechnung der Fl�che 
  *pFl�che = *pL�nge * *pBreite;
  
  //Ausgabe von L�nge, Breite und Fl�che
  printf("Die Flaeche ist %i\n\n\n",*pFl�che);

  system("pause");
  return 0;
}
