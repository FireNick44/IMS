#include <stdio.h>
#include <stdlib.h>

int main()
{
  int value1, value2;
  printf("\nBitte Zahl eingeben:\t\t");
  scanf_s("%i", &value1);
  printf("\nBitte Zahl eingeben:\t\t");
  scanf_s("%i", &value2);
  if (value1 > value2 && value1> 100) //Das logische UND
  {
    printf("\n Die zuerst eingegebene Zahl ist grösser als die zweite und grösser als 100.\n");
  }

  else if (value1 == value2) { 
    printf("\n Sie haben die gleichen Zahlen eingegeben\n");
  }

  else
    printf("\nDie zuerst eingegebene Zahl ist kleiner als 100 oder kleiner als die zweite\n");

  system("pause");
  return 0;
}