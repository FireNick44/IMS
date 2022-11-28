#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  char x;
  printf("\nBitte geben Sie einen Buchstaben von a bis c ein: ");
  scanf_s(" %c",&x,1);

  if (x == 'A' || x == 'a') {
    printf("Sie haben %c eingegeben\n\n\n", x);
  }

  else if (x == 'B' || x == 'b') {
    printf("Sie haben %c eingegeben\n\n\n", x);
  }

  else if (x == 'C' || x == 'c') {
    printf("Sie haben %c eingegeben\n\n\n", x);
  }

  else {
    printf("Sie haben einen falschen Buchstaben eingegeben.\n\n\n");
  }
  system("pause");
  return 0;

}