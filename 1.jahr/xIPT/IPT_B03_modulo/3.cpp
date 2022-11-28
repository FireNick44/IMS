#include<stdlib.h>
#include<stdio.h>
void main()
{
  int eingabe, zahl1, zahl2, zahl3, zahl4, ausgabe;
  printf("Geben Sie eine Zahl zwischen 0 und 9999 ein: ");
  scanf_s("%i", &eingabe);

  zahl1 = eingabe / 1000;
  zahl2 = (eingabe / 100) % 10;
  zahl3 = (eingabe / 10) % 10;
  zahl4 = eingabe % 10;
  ausgabe = zahl1 + zahl2 + zahl3 + zahl4;

  printf("Die Quersumme der Zahl ist %i\n", ausgabe);
  system("pause");
}