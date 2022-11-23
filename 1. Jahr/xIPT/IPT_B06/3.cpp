#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>


int main()
{
  int x;
  int count = 0;
  srand((unsigned)time(NULL));

  printf("Ich generiere nun 10 zuf\x84llige Zahlen zwischen 0 und 99 und gebe sie aus.\n");
  printf("Um fortzufahren, ");
  system("pause");

  printf("Zufallszahlen: ");
  do
  {
    x = rand() % 100;
    printf("%i",x);
    count++;
    
    if (count == 10);
    else if (count >= 9) printf(" und ");
    else printf(", ");

  } while (count < 10);

  printf("\n\n\n");
  system("\npause");
  return 0;
}