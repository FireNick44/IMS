#include <stdio.h>
#include <stdlib.h>

int main()

{
  int x, y;
  printf("\nBitte x eingeben:\t\t");
  scanf_s("%i", &x);
  printf("\nBitte y eingeben:\t\t");
  scanf_s("%i", &y);

  if (x > y){
    printf("\nDie 1. Zahl x=%i ist groesser.", x);}
    
  else if  (x < y) {
    printf("\nDie 1. Zahl x=%i ist kleiner.", x);}
    
  else {
printf("\nDie beiden Zahlen sind gleich gross.");
  }

  system("pause");
  return 0;
}