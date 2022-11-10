#include<stdlib.h>
#include<stdio.h>
void main()
{
  unsigned char gewicht, groesse, alter, gmann, gfrau;
    printf("Geben Sie Ihre K\x94rpergr\x94sse in cm ein:\t");
    scanf_s("%hhu", &groesse);
    printf("Geben Sie Ihr Alter in Jahren ein:\t");
    scanf_s("%hhu", &alter);
    printf("Geben Sie ihr K\x94rpergewicht in kg ein:\t");
    scanf_s("%hhu", &gewicht);
    gmann = 66.47 + 13.7 * gewicht + 5 * groesse - 6.8 * alter;
    gfrau = 655.1 + 9.6 * gewicht + 1.8 * groesse - 4.7 * alter;
    printf("\n\n\nMann: %4.2f Kalorien pro Tag\n",gmann);
    printf("Frau: %4.2f Kalorien pro Tag\n", gfrau);
    system("pause");
}