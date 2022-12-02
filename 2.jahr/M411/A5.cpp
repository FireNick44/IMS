#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
  // 01.
  int Wert; 
  int Zahl = 345;

  //
  // 
  // 
  // 2. 3. 4.
  int* pZeig1 = &Zahl;
  int* pZeig2 = &Wert;
  
  // 05.
  *pZeig2 = 45;
  
  // 06.
  pZeig2 = pZeig1;

  // 07.
  *pZeig2 = 100;

  // 08.
  printf("Wert    der Zahl = %i\n", *pZeig2);
  printf("Adresse der Zahl = %i\n\n\n", pZeig2);

  // 09.
  // 10. F
  // 11.

  system("pause");
  return 0;
}
