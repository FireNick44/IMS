//Yannic First Code 3. Semester

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <cstdlib>
#include <time.h>

int main() //guid = Globla User Interface 
{
  double C = 0.0;
  double F = 0.0;

  printf("Geben Sie die Anzahl Celsius ein: ");
  scanf_s("%lf", &C);
  F = ((C * 9.0 / 5.0) + 32.0);
  printf("%.2lf Celsius sind = %.2lf Fahrenheit.\n\n\n",C,F);
  system("pause");
  return 0;
}