#include <stdio.h>
#include <stdlib.h>

int main()
{
  char zeichen;
  printf("Gib Zahl zw. 0-255: ");
  scanf_s("%i", &zeichen);
  printf("Das Zeichen entspricht im ASCII-Code %c\n", zeichen);
  system("pause");
  return 0;
}