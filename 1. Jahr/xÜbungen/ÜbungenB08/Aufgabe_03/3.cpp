#include <stdio.h>
#include <stdlib.h>
#define Pi 3.1415926535
double Kreisfläche(double);
double Kreisumfang(double);

int main()
{
  double radius = 0;
  printf("Geben Sie den Radius ein:");
  scanf_s("%lf", &radius);
  (Kreisfläche(radius));
  (Kreisumfang(radius));
  printf("Umfang ist %lg\n", radius);
  printf("Fl ist %lg\n", radius);
  printf("Geben Sie den Radius ein:");

  system("pause");
}

double Kreisumfang(double radius)
{
  return(2 * radius* Pi);

}double Kreisfläche(double radius)
{
  return(radius * radius * Pi);
}