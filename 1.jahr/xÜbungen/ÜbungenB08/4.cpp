#include <stdio.h>
#include <stdlib.h>
#define pi 3.1415926

float UP1(float, float);
float UP2(float, float, float);
int main()
{
  char cWahl = '0';
  float fRadiusAussen, fRadiusInnen, fHoehe, fVolumen = 0;

  printf("-----------------------------------------\n");
  printf("| Berechnung von geometrischen Koerpern |\n");
  printf("-----------------------------------------\n\n");
  printf("Bitte wählen Sie einen geometrischen Körper: [Z = Zylinder, H= Hohlzylinder]:");
  scanf_s(" %c", &cWahl, 1);

  if ('Z' == cWahl || 'z' == cWahl)
  {
    printf("Radius:");
    scanf_s("%f", &fRadiusAussen);
    printf("Hoehe:");
    scanf_s("%f", &fHoehe);

    fVolumen = UP1(fRadiusAussen, fHoehe); //De shit do
    printf("Das Volumen ist gleich : %0.3f", fVolumen);
  }
  else if ('H' == cWahl || 'h' == cWahl)
  {
    printf("Radius Aussen:");
    scanf_s("%f", &fRadiusAussen);
    printf("Radius Innen:");
    scanf_s("%f", &fRadiusInnen);
    printf("\nHoehe:");
    scanf_s("%f", &fHoehe);

    fVolumen = UP2(fRadiusAussen, fRadiusInnen, fHoehe);
    printf("Das Volumen ist gleich : %f", fVolumen);
  }
  system("pause");
}

float UP1(float fRadiusAussen, float fHoehe)
{
  float ausgabe;                                       // Alternativ
  ausgabe = pi * fRadiusAussen * fRadiusAussen * fHoehe;

  return(ausgabe);
  /*return(pi * fRadiusAussen * fRadiusAussen * fHoehe); //nur 1 return pro UP*/
}

float UP2(float fRadiusAussen, float fRadiusInnen, float fHoehe)
{
  /*f = (pi * fRadiusAussen * fRadiusAussen * fHoehe);
  f = (pi * fRadiusInnen * fRadiusInnen * fHoehe);*/
  return(pi * (fRadiusAussen * fRadiusAussen - fRadiusInnen * fRadiusInnen) * fHoehe);
}