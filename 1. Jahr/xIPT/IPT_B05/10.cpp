#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  int y, z, l;
  char x;
  printf("M\x94""chten Sie eine Kreis oder Rechtecksfl\x84""che Berechnen\n");
  printf("K oder R\n");
  scanf_s(" %c",&x,1);

  if (x == 'r') {
    printf("Geben Sie die L\x84nge in cm ein:\n");
    scanf_s("%i", &y);
    printf("Geben Sie die H\x94he in cm ein:\n");
    scanf_s("%i", &z);

    l = y * z;

    printf("Die Fl\x84""che betr\x84gt %i cm im Quadrat\n", l);
}
  else if (x == 'k') {
    printf("Geben Sie den Radius in cm ein:\n");
    scanf_s("%i", &y);

    l = y* y * 3.14159265358979323;

    printf("Die Fl\x84""che betr\x84gt %i cm im Quadrat\n", l);
  }
  else {
  printf("Sie haben einen falschen Buchstaben eingegeben.\n");

  }

  system("pause");
  return 0;

}