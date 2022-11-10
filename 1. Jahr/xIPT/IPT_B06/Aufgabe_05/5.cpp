

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <time.h>


int main()
{
 char auswahl;
 int x = 0;
 do {
   printf("Hauptmen\x81\n");
   printf("=========\n\n");
   printf("1: Programmteil A...\n");
   printf("2: Programmteil B...\n");
   printf("3: Programmteil C...\n\n");
   printf("x: Programm beenden\n\n");
   printf("Men\x81""code eingeben: ");

   scanf_s(" %c", &auswahl, 1);
   system("cls");

   switch (auswahl)
   {
   case '1':
   case '2':
   case '3':
     printf("Programmteil %c wird ausgef\x81hrt\n", auswahl);
     break;

   case 'x':
     printf("Das Programm wird beendet\n");
     x = 1;
     break;

   default:
     printf("Falsche Eingabe!\n");
     break;
   }

   system("pause");
   system("cls");
 } while (x == 0);
 return 0;
}