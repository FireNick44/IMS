#include <stdio.h>
#include <stdlib.h>
double Rechteckflaeche(double, double);
int main()
{
  double l�nge = 0;
  double breite = 0;
  double fl�che = 0;

  printf("Geben Sie die L\x84nge ein:");
  scanf_s("%lf", &l�nge);
  printf("Geben Sie die Breite ein:");
  scanf_s("%lf", &breite);

  fl�che = Rechteckflaeche(l�nge, breite);

  printf("Die Fl\x84""che des Rechtecks: %lg\n", fl�che);
  system("pause");
}

double Rechteckflaeche(double l, double b)
{
  double f;
  f = l * b;
  return(f);
}