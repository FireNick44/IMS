#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  system("color a");
  int h�he = 0;
  int breite = 0;
  int count1 = 0;
  int count2 = 0;

  printf("Geben Sie die eine H\x94he und Breite ein.\n");
  printf("H\x94he:\t");
  scanf_s("%i",&h�he);
  printf("Breite\t");
  scanf_s("%i",&breite);
  printf("\n\n\n");

  do
  {
   while (count1 !=breite) 
   {
    printf(" O");
    count1++;
   }
   printf("\n");
   count1 = 0;
   count2++;
  } while (count2 <= h�he-1);
 
  printf("\n\n\n");
  system("pause");
  return 0;
}