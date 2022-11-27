#include <stdio.h>
#include <stdlib.h>
float ce(float);
float fh(float);

int main()
{
  char eingabe = 'X';
  float celsius = 0;
  float fahrenheit = 0;

  printf("Was m\x94""chten Sie umwandeln Celsius oder Fahrenheit\n");
  printf("Celsius in Fahrenheit = C\n");
  printf("Fahrenheit in Celsius = F\n");
  scanf_s(" %c",&eingabe, 1);
  system("cls");

  if (eingabe == 'C' || eingabe == 'c')
  {
    printf("Anzahl Celsius: ");
    scanf_s("%f", &celsius);
    fahrenheit = fh(celsius);
    printf("Anzahl Fahrenheit: %3.1f", fahrenheit);
  }

  else if (eingabe == 'F' || eingabe == 'f')
  {
    printf("Anzahl Fahrenheit: ");
    scanf_s("%f", &fahrenheit);
    celsius = ce(fahrenheit);
    printf("Anzahl Celsius: %3.1f", celsius);
  }
  printf("\n");
  system("pause");
}

float ce(float f)
{
  return( f = ((f - 32) * 5 / 9));
}

float fh(float c)
{
  return( c = ((c * 9 / 5) +32));
}