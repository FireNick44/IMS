#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int t, m, j;

  printf("Tag:");
  scanf_s("%i", t);
  printf("Monat:");
  scanf_s("%i", m);
  printf("Jahr:");
  scanf_s("%i", j);

  if (m <= 2)
  {
    m + 10;
    j - 1;
  }
  else
  {
    m - 2;
  }

  c = j / 100;
  j = j % 100

    h = (((26 * m - 2) / 10) + t + j + j / 4 + c)
    system("pause");
  return 0;
}