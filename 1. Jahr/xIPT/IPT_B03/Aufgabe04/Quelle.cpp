#include<stdlib.h>
#include<stdio.h>
#include<cstdlib>
#include <time.h>

void main()
{
  srand(time(NULL));
  char zahl1 = rand() % 41 + 1,
    zahl2 = rand() % 41 + 1,
    zahl3 = rand() % 41 + 1,
    zahl4 = rand() % 41 + 1,
    zahl5 = rand() % 41 + 1,
    zahl6 = rand() % 41 + 1,
    glueck = rand() % 6 + 1;
  printf("Die Lottozahlen sind:\t%hi,"
    "\n\t\t\t%hi,"
    "\n\t\t\t%hi,"
    "\n\t\t\t%hi,"
    "\n\t\t\t%hi,"
    "\n\t\t\t%hi\n", zahl1, zahl2, zahl3, zahl4, zahl5, zahl6);
  printf("Die Gl\x81""ckszahl ist:\t%hi\n", glueck);
  system("pause");
}