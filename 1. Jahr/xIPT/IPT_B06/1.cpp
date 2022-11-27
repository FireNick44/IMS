#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>


int main()
{
  printf("Ich generiere nun 10 zuf\x84llige Zahlen\n");
  printf("Um fortzufahren, ");
  system("pause");

  int x;
  srand((unsigned)time(NULL));

  for (x = 1; x<11;x++)
  {
    printf("Zufallszahl:\t %i\n", rand ());
  }

 system("pause");
 return 0;
}