#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>


int main()
{
  int x;
  int max = 0;
  int min = 100;
  float zusammen = 0;
  int count = 0;
  srand((unsigned)time(NULL));

  printf("Ich generiere nun 20 zuf\x84llige Zahlen zwischen 0 und 99 und gebe den Mittelwert aus.\n");
  printf("Um fortzufahren, ");
  system("pause");
  
  do
  {
    x = rand() % 100;
    zusammen = zusammen + x; //summe += x kurz
    count++;
    if (x <= min) min = x;
    else if (x >= max) max = x;
  } while (count < 20);

  zusammen = zusammen / 20;
  printf("Maximum\t\t= %2.1i\n", max);
  printf("Minimum\t\t= %2.1i\n", min);
  printf("Mittelwert\t= %2.1f\n", zusammen);

  system("pause");
  return 0;
}