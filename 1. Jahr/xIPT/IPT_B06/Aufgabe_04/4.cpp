#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <cstdlib>
#include <time.h>
int UP1();
int UP2();

int main()
{

  system("mode con cols=170 lines=40");
  system("color b");

  srand((unsigned)time(NULL));
  int min = 0;
  int max = 0;
  int eingabe;
  int count = 0;
  int end = 0;
  int again = 0;
  char yn = 'a';
  char lvl = 'x';

  while (again == 0)
  {
    UP1();

    printf("Wir Spielen ein Spiel, erraten Sie so schnell wie m\x94glich meine Zahl!\n");
    printf("W\x84hlen Sie eine schwierigkeit aus:\n\n");

    printf("V = Very Hard:\t Zahlen von 0 bis 30000\n");
    printf("H = Hard:\t Zahlen von 0 bis 1000\n");
    printf("E = Easy:\t Zahlen von 0 bis 10\n\n");
    scanf_s(" %c", &lvl, 1);

    // Difficulty
    switch (lvl)
    {
    case 'V':
    case 'v':
      max = 30000;
      break;

    case 'H':
    case 'h':
      max = 1000;
      break;

    case 'E':
    case 'e':
      max = 10;
      break;
    }

    int x = rand() % max + 1;

    printf("Um fortzufahren, ");
    system("pause");
    system("cls");

    //while des games
    while (end == 0)
    {
      system("cls"); //count und clear der cms
      count++;
      UP1();

      printf("Geben Sie eine Zahl zwischen %i und %i ein: ", min, max);
      scanf_s("%i", &eingabe);

      //lösung anzeige
      if (eingabe == x)
      {
        printf("Sie haben es geschaft!\n");
        printf("Die Gesuchte Zahl war %i\n", x);
        if (count == 1)
        {
          printf("Sie haben %i Versuch Gebraucht\n\n\n", count);
        }
        else
        {
          printf("Sie haben %i Versuche Gebraucht\n\n\n", count);
        }
        end = 1;
        system("pause");
        system("cls");
      }

      //wenn grösser als x
      else if (eingabe <= x)
      {
        printf("Die Zahl ist gr\x94sser als %i\n\n\n", eingabe);
        min = eingabe;
        system("pause");
      }

      //wenn kleiner als x
      else if (eingabe >= x)
      {
        printf("Die Zahl ist kleiner als %i \n\n\n", eingabe);
        max = eingabe;
        system("pause");
      }

    }
    printf("M\x94""chten Sie das Spiel nochmal spielen?.\n");
    printf("Y/N.\t");
    scanf_s(" %c", &yn, 1);

    //if Y
    if (yn == 'Y' || yn == 'y')
    {
      again = 0;
      end = 0;
      min = 0;
      max = 1000;
      count = 0;
      x = rand() % 1000 + 1;
    }

    //if N
    else if (yn == 'N' || yn == 'n')
    {
      again = 1;
      system("cls");
      printf("Sie haben das Spiel beendet.\n");
    }
  }
  system("cls");
  UP1;
  system("pause");
  return 0;
}


int UP1()
{
  printf("  .oooooo.                                                   .   oooo                      ooooo      ooo                                .o8                          \n");
  printf(" d8P'  `Y8b                                                .o8   `888                      `888b.     `8'                               '888                          \n");
  printf("888           oooo  oooo   .ooooo.   .oooo.o  .oooo.o    .o888oo  888 .oo.    .ooooo.       8 `88b.    8  oooo  oooo  ooo. .oo.  .oo.    888oooo.   .ooooo.  oooo  d8b\n");
  printf("888           `888  `888  d88' `88b d88(  '8 d88('8        888    888P'Y88b  d88' `88b      8   `88b.  8  `888  `888  `888P'Y88bP'Y88b   d88' '88b d88' '88b `888''8P \n");
  printf("888     ooooo  888   888  888ooo888 `'Y88b.  `'Y88b.       888    888   888  888ooo888      8     '88b.8   888   888   888   888   888   888   888 888ooo888  888     \n");
  printf("`88.    .88'   888   888  888    .o o.  )88b o.  )88b      888 .  888   888  888    .o      8       `888   888   888   888   888   888   888   888 888    .o  888     \n");
  printf(" `Y8bood8P'    `V88V'V8P' `Y8bod8P' 8''888P' 8''888P'      '888' o888o o888o 'Y8bod8P'     o8o        `8   `V88V'V8P' o888o o888o o888o  `Y8bod8P' `Y8bod8P' d888b    \n\n\n");
  return(0);
}

int UP2()
{
  printf("oooooooooooo                   .o8  \n");
  printf("`888'     `8                  '888  \n");
  printf(" 888         ooo. .oo.    .oooo888  \n");
  printf(" 888oooo8    `888P'Y88b  d88' `888  \n");
  printf(" 888    '     888   888  888   888  \n");
  printf(" 888       o  888   888  888   888  \n");
  printf("o888ooooood8 o888o o888o `Y8bod88P' \n\n\n");
  return(0);
}