#include <stdio.h>
#include <stdlib.h>
double Rechteckflaeche(double, double);
int main()
{
  double länge = 0;
  double breite = 0;
  double fläche = 0;

  printf("Geben Sie die L\x84nge ein:");
  scanf_s("%lf", &länge);
  printf("Geben Sie die Breite ein:");
  scanf_s("%lf", &breite);

  fläche = Rechteckflaeche(länge, breite);

  printf("Die Fl\x84""che des Rechtecks: %lg\n", fläche);
  system("pause");
}

double Rechteckflaeche(double l, double b)
{
  double f;
  f = l * b;
  return(f);
}