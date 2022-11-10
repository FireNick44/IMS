/***************************************************
Datentypen mit ihrem Speicherbedarf und Wertebereich
****************************************************/
#include <stdio.h> 
#include <stdlib.h> 
#include <limits.h> 	//enthält MIN und MAX zu den Ganzzahligen-Datentypen 
#include <float.h> 	//enthält MIN und MAX zu den Fliesskomma-Datentypen 

int main()
{
  printf("\nTyp\t\t\tGroesse\t\tMinimalwert\t\tMaximalwert\n");
  printf("\n%s\t\t\t%u\t\t%i\t\t\t%i", "char", sizeof(char), CHAR_MIN, CHAR_MAX);  
  printf("\n%s\t\t%u\t\t%u\t\t\t%u", "unsigned char", sizeof(unsigned char), 0, UCHAR_MAX);  
  printf("\n%s\t\t%u\t\t%i\t\t\t%i", "signed char", sizeof(signed char), SCHAR_MIN, SCHAR_MAX);
  printf("\n%s\t\t\t%u\t\t%i\t\t%i", "int", sizeof(int), INT_MIN, INT_MAX); 
  printf("\n%s\t\t%u\t\t%u\t\t\t%u", "unsigned int", sizeof(unsigned int), 0, UINT_MAX);  
  printf("\n%s\t\t%u\t\t%i\t\t%i", "signed int", sizeof(signed int), INT_MIN, INT_MAX);
  printf("\n%s\t\t%u\t\t%i\t\t\t%i", "short int", sizeof(short int), SHRT_MIN, SHRT_MAX);  
  printf("\n%s\t%u\t\t%u\t\t\t%u", "unsigned short int", sizeof(unsigned short int), 0, USHRT_MAX);  
  printf("\n%s\t%u\t\t%i\t\t\t%i", "signed short int", sizeof(signed short int), SHRT_MIN, SHRT_MAX);  
  printf("\n%s\t\t%u\t\t%li\t\t%li", "long int", sizeof(long int), LONG_MIN, LONG_MAX);  
  printf("\n%s\t%u\t\t%lu\t\t\t%lu", "unsigned long int", sizeof(unsigned long int), 0, ULONG_MAX);  
  printf("\n%s\t\t%u\t\t%li\t\t%li", "signed long int", sizeof(signed long int), LONG_MIN, LONG_MAX);
  printf("\n%s\t\t\t%u\t\t%G\t\t%G", "float", sizeof(float), FLT_MIN, FLT_MAX);  
  printf("\n%s\t\t\t%u\t\t%G\t\t%G", "double", sizeof(double), DBL_MIN, DBL_MAX);  
  printf("\n%s\t\t%u\t\t%LG\t\t%LG", "long double", sizeof(long double), LDBL_MIN, LDBL_MAX);  
  printf("\n\n");
  system("pause");
  return 0;
}
