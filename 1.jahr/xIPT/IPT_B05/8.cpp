#include <stdio.h>
#include <stdlib.h>

int main()
{
  int T1, T2;
  printf("\nBitte Term1 eingeben:\t\t");
  scanf_s("%i", &T1);
  printf("\nBitte Term2 eingeben:\t\t");
  scanf_s("%i", &T2);

  if (T1 > T2 || T1>100) //Das logische ODER
  {
    printf("\nTerm 1 ist grösser als Term2 oder grösser als 100 oder beides.\n");
  }

  else if (T1 == T2) 
  {
    printf("Sie haben die gleichen Zahlen eingegeben\n");
  }

  else
    printf("Term 1 ist kleiner als 100 oder kleiner als Term2 oder beides.\n");

  system("pause");
  return 0;

}