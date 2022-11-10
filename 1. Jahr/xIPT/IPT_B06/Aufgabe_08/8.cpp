#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <cstdlib>
#include <time.h>

void ausgabe(char, char, char, char, char, char, char, char, char);
void grafik();

int main()
{
  srand((unsigned)time(NULL));
  char E1 = '1';
  char E2 = '2';
  char E3 = '3';
  char E4 = '4';
  char E5 = '5';
  char E6 = '6';
  char E7 = '7';
  char E8 = '8';
  char E9 = '9';

  int end_programm_wert = 0;
  int end_programm_wert2 = 0;
  int spielmodus = 0;
  char beenden_confirm = 0;

  while (end_programm_wert2 == 0)
  {
    do
    {
      void grafik();

      printf("ooooooooooooo  o8o                 ooooooooooooo                          ooooooooooooo                     \n");
      printf("8'   888   `8  `''                 8'   888   `8                          8'   888   `8                     \n");
      printf("     888      oooo   .ooooo.            888       .oooo.    .ooooo.            888       .ooooo.   .ooooo.  \n");
      printf("     888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
      printf("     888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
      printf("     888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
      printf("    o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n\n\n");

      printf("W\x84hlen Sie ihren Spielmodus:\n");
      printf("1 Spieler = 1\n");
      printf("2 Spieler = 2\n");
      printf("Beenden   = 3\n");
      printf("\n(1/2/3) ");
      scanf_s("%i", &spielmodus);
      system("cls");

      //1 player
      if (spielmodus == 1)
      {
        printf("KI in bearbeitig\nHETZ MICH NED \n");
        system("timeout 3 >nul");
        system("cls");
      }

      //2 player
      else if (spielmodus == 2)
      {
        int count_2p = 0;
        int end_2p = 0;
        int weiter_2p = 0;
        int fehler_2p = 0;

        char runde_2p = '1';
        char letzte_runde_2p = '2';
        char eingabe_2p = ' ';


        printf("Spieler 1 = O\n");
        printf("Spieler 2 = X\n");
        system("timeout 2 >nul");
        system("cls");

        count_2p = rand() % 2 + 1;

        while (end_2p == 0)
        {

          if (count_2p == 3) count_2p = 1;

          else if (count_2p == 0) count_2p = 2;

          //wenn ein fehler
          else if (fehler_2p == 1)
          {
            printf("Du kannst dieses Feld nicht W\x84hlen\n");
            system("pause");
            system("cls");
            fehler_2p = 0;
            count_2p--;
          }
          //wenn kein fehler
          else if (fehler_2p == 0)
          {
            if (count_2p == 1)
            {
              letzte_runde_2p = 'X';
              runde_2p = 'O';
              weiter_2p = 0;
            }

            else if (count_2p == 2)
            {
              letzte_runde_2p = 'O';
              runde_2p = 'X';
              weiter_2p = 0;
            }
          }
          //Ausgabe von X/O abhänig von runde_2p
          while (weiter_2p == 0)
          {
            printf("Spieler %i ist am Zug\n", count_2p);
            printf("Wählen Sie ein Feld aus.\n\n");
            ausgabe(E1, E2, E3, E4, E5, E6, E7, E8, E9);
            scanf_s(" %c", &eingabe_2p, 1);

            // ALLE eingaben (1-9)

            //eingabe auf E1
            if (eingabe_2p == '1')
            {
              if (E1 == letzte_runde_2p) fehler_2p = 1;
              else if (E1 != runde_2p && fehler_2p == 0) E1 = runde_2p;
            }

            system("cls");
            printf("Spieler %i ist am Zug\n\n\n", count_2p);

            ausgabe(E1, E2, E3, E4, E5, E6, E7, E8, E9);

            count_2p++;
            weiter_2p = 1;
            system("cls");

          }
        }
      }

      //end
      else if (spielmodus == 3)
      {
        end_programm_wert = 1;
      }

      //falsche eingabe
      else
      {
        //falsche eingabe
        printf("Falsche Eingabe\n");
        system("timeout 1 >nul");
        system("cls");
      }

    } while (end_programm_wert == 0);

    printf("Möchten Sie das Spiel wirklich beenden?\n");
    printf("(Y/N) ");
    scanf_s(" %c", &beenden_confirm, 1);

    if (beenden_confirm == 'Y' || beenden_confirm == 'y') end_programm_wert2 = 1;
    else if (beenden_confirm == 'N' || beenden_confirm == 'n') end_programm_wert = 0;
  }

  system("pause");
  return(0);
}

void ausgabe(char E1, char E2, char E3, char E4, char E5, char E6, char E7, char E8, char E9)
{
  printf("\n         |         |        \n");
  printf("    %c    |    %c    |    %c   \n", E1, E2, E3);
  printf("         |         |        \n");
  printf("---------+---------+--------\n");
  printf("         |         |        \n");
  printf("    %c    |    %c    |    %c   \n", E4, E5, E6);
  printf("         |         |        \n");
  printf("---------+---------+--------\n");
  printf("         |         |        \n");
  printf("    %c    |    %c    |    %c   \n", E7, E8, E9);
  printf("         |         |        \n\n");
}

void grafik()
{
  printf("ooooooooooooo  o8o                 ooooooooooooo                          ooooooooooooo                     \n");
  printf("8'   888   `8  `''                 8'   888   `8                          8'   888   `8                     \n");
  printf("     888      oooo   .ooooo.            888       .oooo.    .ooooo.            888       .ooooo.   .ooooo.  \n");
  printf("     888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
  printf("     888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("     888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("    o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n");
}