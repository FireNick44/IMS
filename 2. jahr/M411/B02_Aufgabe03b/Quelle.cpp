//Yannic First Code 3. Semester

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <cstdlib>
#include <time.h>

double C = 0.0;
double F = 0.0;

void CelsiusToFahrenheit()
{
  F = ((C * 9.0 / 5.0) + 32.0);
}

int main()
{
  printf("Geben Sie die Anzahl Celsius ein: ");
  scanf_s("%lf", &C);

  CelsiusToFahrenheit();

  printf("%.2lf Celsius sind = %.2lf Fahrenheit.\n\n\n", C, F);
  system("pause");
  return 0;
}
