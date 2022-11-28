#include<stdio.h>
#include<stdlib.h>

int main()
{
  short zahl = 0;
  printf("Geben ein Nummer: ");
  scanf_s("%hi",&zahl);
  printf("Eingegeben wurde: %hi\n\n", zahl);
  system("pause");
    return 0;
}