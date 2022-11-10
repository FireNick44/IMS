#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#define anzahlMenschen
int main()
{
  const double avggewichtMensch = 60.2;     //kg
  double volumenSee;
  //Eingabe
  printf("Volumen des Sees in km3: ");
  scanf_s("%lf", &volumenSee);
  volumenSee *= pow(10, 9);

  //Verarbeitung
  double volumenMenschheit = anzahlMenschen * (avggewichtMensch/1000);
  int resultat = volumenSee / volumenMenschheit * 100;

  //Ausgabe
  printf("%d %% der Meschheit h\x84tte platz\n");
  system("pause");
  return 0;
}