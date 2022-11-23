#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  float t;
  printf("Geben sie einen Temepraturwert ein:\n");
  scanf_s(" %f", &t);

  if (t <= 0) {
    printf("Das Wasser gefriert.\n\n\n");
  }
  else if (t >= 100) {
    printf("Das Wasser Verdampft.\n\n\n");
  }
  else {
    printf("Das Wasser bleibt fl\x81ssig\n\n\n");

  }

  system("pause");
  return 0;

}