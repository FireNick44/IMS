#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>


int main()
{
  int zahl1 = 0;
  int zahl2 = 0;
  int ausgabe = 0;
  int rest = 0;
  char test = 'j';
  char x;

  while (test == 'j' || test == 'J')
  {
  printf("1. ganze Zahl eingeben: ");
  scanf_s("%i", &zahl1);
  printf("2. ganze Zahl eingeben: ");
  scanf_s("%i", &zahl2);
  printf("Operator ( +, -, * oder / )eingeben: ");
  scanf_s(" %c", &x,1);

  switch (x) 
  {
    case '+':
      ausgabe = zahl1 + zahl2;
      printf("\n\n%i %c %i = %i\n\n", zahl1, x, zahl2, ausgabe);
      break;

    case '-':
      ausgabe = zahl1 - zahl2;
      printf("\n\n%i %c %i = %i\n\n", zahl1, x, zahl2, ausgabe);
      break;

    case '*':
      ausgabe = zahl1 * zahl2;
      printf("\n\n%i %c %i = %i\n\n", zahl1, x, zahl2, ausgabe);
      break;

    case '/':
      
      printf("\n\n%i %c %i = %i rest = %i\n\n", zahl1, x, zahl2, ausgabe,rest);
      break;
  }

  printf("Noch eine Berechnung (J/N)? ");
  scanf_s(" %c", &test,1);
  }

  printf("\n\nProgramm wird beendet...\n");
  system("pause");
  return 0;
}