/***********************************************************
  Tic Tac Toe                von Yannic Studer               
 ***********************************************************/

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <cstdlib>
#include <time.h>
#include <string.h>
#include <Windows.h>

//Unterprogramme für main 
void animation();
void grafik();

//Unterprogramm 1P(KI) / 2P(Multiplayer)
void p1();
void p2();

//Unterprogramme für 1P/2P
void ausgabe(char[]);
void winn_x(char[]);
void winn_o(char[]);
void unentschieden();

//Unterprogramm Settings
int settings(int,int);//kann kein unterprogramm sein
int farbmatrix(char, char);


//Main Programm
int main()
{
  system("mode con cols=138 lines=30");
  system("color 0F");
  //animation(); //Animation
  srand((unsigned)time(NULL)); //Zufall

  int end_programm_wert = 0;
  int end_programm2_wert = 0;
  int end_settings = 0;
  int anz_aufrufe_settings = 0; //Wenn geändert werden Farben nicht mehr mit "Standart" überschrieben

  char spielmodus = '0';
  char beenden_confirm = 0;

  while (end_programm2_wert == 0)
  {
    while (end_programm_wert == 0)
    {

      grafik();

      printf("\n  W\x84hlen Sie ihren Spielmodus:\n");
      printf("  1 Spieler     = 1\n");
      printf("  2 Spieler     = 2\n\n");
      printf("  Beenden       = 3\n");
      printf("  Einstellungen = 4\n");

      printf("\n  (1/2/3/4): ");
      scanf_s(" %c", &spielmodus, 1);

      //1 player
      if (spielmodus == '1')                                                p1();
      //2 player
      else if (spielmodus == '2')                                           p2();
      //settings
      else if (spielmodus == 'E' || spielmodus == 'e' || spielmodus == '4') settings(anz_aufrufe_settings,end_settings);
      //end
      else if (spielmodus == 'B' || spielmodus == 'b' || spielmodus == '3') end_programm_wert = 1;
      //falsche eingabe
      else if (spielmodus != '1' && spielmodus != '2' && spielmodus != '3' && spielmodus != '4' || spielmodus != 'b' || spielmodus != 'B' || spielmodus == 'E' || spielmodus == 'e')
      {
        printf("  Falsche Eingabe\n");
        system("timeout 1 >nul");
        system("cls");
        spielmodus = 0;

      }
    }

    // Nachfrage zum Beenden
    system("cls");
    printf("\n  M\x94""chten Sie das Spiel wirklich beenden?\n");
    printf("  (J/N) ");
    scanf_s(" %c", &beenden_confirm, 1);
    system("cls");

    if (beenden_confirm == 'N' || beenden_confirm == 'n') end_programm_wert = 0;
    else end_programm2_wert = 1;
  }
}

//Unterprogramme für main
void animation()
{
  printf("\n \n\n\n\n\n\n\n\n                                         Yannic Studer Pr\x84sentiert                                            \n");
  Sleep(400);
  system("cls");
  printf("\n \n\n\n\n\n\n\n                                         Yannic Studer Pr\x84sentiert                                            \n\n");
  Sleep(400);
  system("cls");
  printf("\n \n\n\n\n\n\n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n");
  Sleep(400);
  system("cls");
  printf("\n \n\n\n\n\n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n\n");
  Sleep(400);
  system("cls");
  printf("\n \n\n\n\n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n\n\n");
  Sleep(400);
  system("cls");
  printf("\n \n\n\n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n\n\n\n");
  Sleep(400);
  system("cls");
  printf("\n \n\n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n\n\n\n\n");
  Sleep(400);
  system("cls");
  printf("\n \n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n\n\n\n\n\n");
  Sleep(400);
  system("cls");
  printf("\n                                         Yannic Studer Pr\x84sentiert                                            \n\n\n\n\n\n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n\n\n\n\n\n\n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n \n\n\n\n\n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n \n\n\n\n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n       888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n \n\n\n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n       888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
  printf("       888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n \n\n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n       888      oooo   .ooooo.            888       .oooo.    .ooooo.            888       .ooooo.   .ooooo.  \n");
  printf("       888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
  printf("       888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n \n\n\n\n");
  Sleep(400);
  system("cls");

  printf("\n  8'   888   `8  `''                 8'   888   `8                          8'   888   `8                     \n");
  printf("       888      oooo   .ooooo.            888       .oooo.    .ooooo.            888       .ooooo.   .ooooo.  \n");
  printf("       888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
  printf("       888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n \n\n\n");
  Sleep(400);
  system("cls");

  printf("\n  ooooooooooooo  o8o                 ooooooooooooo                          ooooooooooooo                     \n");
  printf("  8'   888   `8  `''                 8'   888   `8                          8'   888   `8                     \n");
  printf("       888      oooo   .ooooo.            888       .oooo.    .ooooo.            888       .ooooo.   .ooooo.  \n");
  printf("       888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
  printf("       888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n\n\n");
  Sleep(400);
  system("cls");

}
void grafik()
{
  printf("\n  ooooooooooooo  o8o                 ooooooooooooo                          ooooooooooooo                     \n");
  printf("  8'   888   `8  `''                 8'   888   `8                          8'   888   `8                     \n");
  printf("       888      oooo   .ooooo.            888       .oooo.    .ooooo.            888       .ooooo.   .ooooo.  \n");
  printf("       888      `888  d88' `'Y8           888      `P  )88b  d88' `'Y8           888      d88' `88b d88' `88b \n");
  printf("       888       888  888                 888       .oP'888  888                 888      888   888 888ooo888 \n");
  printf("       888       888  888   .o8           888      d8(  888  888   .o8           888      888   888 888    .o \n");
  printf("      o888o     o888o `Y8bod8P'          o888o     `Y888''8o `Y8bod8P'          o888o     `Y8bod8P' `Y8bod8P' \n\n");
}


// 1 Player 
void p1()
{
  system("cls");
  printf("  KI in bearbeitig\n  HETZ MICH NED            bidde\n");
  system("timeout 3 >nul");
  system("cls");
}

// 2 Player 
void p2()
{

  int win_2p = 0;
  int count_win_2p = 0;
  int count_2p = 0;
  int end_2p = 0;
  int weiter_2p = 0;
  int weiter2_2p = 0;
  int fehler_2p = 0;
  int eingabe_converter_2p = 0;

  char runde_2p = '1';
  char letzte_runde_2p = '2';
  char eingabe_2p = ' ';
  char feld[] = { '1','2','3','4','5','6','7','8','9' };


  system("cls");
  printf("\n  Spieler 1 = O\n");
  printf("  Spieler 2 = X ");
  printf("\n\n  Wer beginnt wird zuf\x84llig ausgew\x84hlt ");
  system("timeout 5 >nul");
  system("cls");

  count_2p = rand() % 2 + 1; //zufall

  //Tic Tac Toe Engine
  while (end_2p == 0)
  {
    //Ausgabe von X/O abhänig von runde_2p. Mit Converter für Char in Aray
    while (weiter_2p == 0)
    {

      //wenn Fehler = True/1
      if (fehler_2p == 1)
      {
        printf("\n  Du kannst dieses Feld nicht W\x84hlen\n");
        system("pause");
        system("cls");
        fehler_2p = 0;
      }

      //wenn Fehler = False/0
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

      weiter2_2p = 0;
      while (weiter2_2p == 0)
      {

        //1. Benutzertext
        printf("\n  Spieler %i ist am Zug\n", count_2p);
        printf("  W\x84hlen Sie ein Feld aus.\n\n");
        ausgabe(feld);
        printf("\n  Feld: ");
        scanf_s(" %c", &eingabe_2p, 1);

        //Converter von Eingabe_2p CHAR in INT
        switch (eingabe_2p)
        {
        case '1':
          eingabe_converter_2p = 0;
          break;
        case '2':
          eingabe_converter_2p = 1;
          break;
        case '3':
          eingabe_converter_2p = 2;
          break;
        case '4':
          eingabe_converter_2p = 3;
          break;
        case '5':
          eingabe_converter_2p = 4;
          break;
        case '6':
          eingabe_converter_2p = 5;
          break;
        case '7':
          eingabe_converter_2p = 6;
          break;
        case '8':
          eingabe_converter_2p = 7;
          break;
        case '9':
          eingabe_converter_2p = 8;
          break;
        }

        //Definierung von "Feld". Fehler = True, wenn "Feld" = wie letzte_runde_2p
        if (feld[eingabe_converter_2p] == letzte_runde_2p) fehler_2p = 1;
        else if (feld[eingabe_converter_2p] != runde_2p) feld[eingabe_converter_2p] = runde_2p;

        count_win_2p++;
        weiter2_2p = 1; //Abbruch der Schleife
        system("cls");
      }

      //Count ++ und Count restet auf 1
      count_2p++;
      if (count_2p == 3) count_2p = 1;

      //Gewinn Prüfung:

      //Horizontal
      if (feld[0] == feld[1] && feld[0] == feld[2]) win_2p = 1;
      else if (feld[3] == feld[4] && feld[3] == feld[5]) win_2p = 1;
      else if (feld[6] == feld[7] && feld[6] == feld[8]) win_2p = 1;
      //Vertikal
      else if (feld[0] == feld[3] && feld[0] == feld[6]) win_2p = 1;
      else if (feld[1] == feld[4] && feld[1] == feld[7]) win_2p = 1;
      else if (feld[2] == feld[5] && feld[2] == feld[8]) win_2p = 1;
      //Diagonal
      else if (feld[0] == feld[4] && feld[0] == feld[8]) win_2p = 1;
      else if (feld[2] == feld[4] && feld[2] == feld[6]) win_2p = 1;

      //Unentschieden wenn nach 9 Runden kein Gewinner
      else if (count_win_2p == 9) win_2p = 2;

      //Unentschieden
      if (win_2p == 2)
      {
        end_2p = 1;//Ende der Schlaufe von Tic Tac Toe
        unentschieden();
        weiter_2p = 1; //abbruch der Schleife
      }

      //Gewinn von X/O bestimmt durch runde_2p
      else if (win_2p == 1)
      {
        switch (runde_2p)
        {
        case 'O':
          winn_o(feld);
          weiter_2p = 1; //abbruch der Schleife
          
          break;
        case 'X':
          winn_x(feld);
          weiter_2p = 1; //abbruch der Schleife
          break;
        }
        end_2p = 1;//Ende der Schlaufe von Tic Tac Toe
      }
    }
    printf("\n\n");
    system("pause");
    system("cls");
  }
}

// Unterprogramme für P1/P2
void ausgabe(char feld[])
{
  printf("\n           |         |        \n");
  printf("      %c    |    %c    |    %c   \n", feld[0], feld[1], feld[2]);
  printf("           |         |        \n");
  printf("  ---------+---------+--------\n");
  printf("           |         |        \n");
  printf("      %c    |    %c    |    %c   \n", feld[3], feld[4], feld[5]);
  printf("           |         |        \n");
  printf("  ---------+---------+--------\n");
  printf("           |         |        \n");
  printf("      %c    |    %c    |    %c   \n", feld[6], feld[7], feld[8]);
  printf("           |         |        \n\n");
}
void winn_x(char feld[])
{
  printf("\n\n    Y88b   d88P      888               888                                                                                        888 \n");
  printf("     Y88b d88P       888               888                                                                                        888 \n");
  printf("      Y88o88P        888               888                                                                                        888 \n");
  printf("       Y888P         88888b.   8888b.  888888       .d88b.   .d88b.  888  888  888  .d88b.  88888b.  88888b.   .d88b.  88888b.    888 \n");
  printf("       d888b         888 '88b     '88b 888         d88P'88b d8P  Y8b 888  888  888 d88''88b 888 '88b 888 '88b d8P  Y8b 888 '88b   888 \n");
  printf("      d88888b        888  888 .d888888 888         888  888 88888888 888  888  888 888  888 888  888 888  888 88888888 888  888   Y8P \n");
  printf("     d88P Y88b       888  888 888  888 Y88b.       Y88b 888 Y8b.     Y88b 888 d88P Y88..88P 888  888 888  888 Y8b.     888  888    '  \n");
  printf("    d88P   Y88b      888  888 'Y888888  'Y888       'Y88888  'Y8888   'Y888'888P'   'Y88P'  888  888 888  888  'Y8888  888  888   888 \n");
  printf("                                                        888                                                                           \n");
  printf("                                                   Y8b d88P                                                                           \n");
  printf("                                                    'Y88P'                                                                            \n");
}
void winn_o(char feld[])
{
  printf("\n\n     .d8888888b.      888               888                                                                                        888 \n");
  printf("    d888P' 'Y888b     888               888                                                                                        888 \n");
  printf("    888       888     888               888                                                                                        888 \n");
  printf("    888       888     88888b.   8888b.  888888       .d88b.   .d88b.  888  888  888  .d88b.  88888b.  88888b.   .d88b.  88888b.    888 \n");
  printf("    888       888     888 '88b     '88b 888         d88P'88b d8P  Y8b 888  888  888 d88''88b 888 '88b 888 '88b d8P  Y8b 888 '88b   888 \n");
  printf("    888       888     888  888 .d888888 888         888  888 88888888 888  888  888 888  888 888  888 888  888 88888888 888  888   Y8P \n");
  printf("    Y88bo. .od88P     888  888 888  888 Y88b.       Y88b 888 Y8b.     Y88b 888 d88P Y88..88P 888  888 888  888 Y8b.     888  888    '  \n");
  printf("     'Y8888888P'      888  888 'Y888888  'Y888       'Y88888  'Y8888   'Y888'888P'   'Y88P'  888  888 888  888  'Y8888  888  888   888 \n");
  printf("                                                         888                                                                           \n");
  printf("                                                    Y8b d88P                                                                           \n");
  printf("                                                     'Y88P'                                                                            \n");
}
void unentschieden()
{
  printf("\n\n    888     888                            888                      888      d8b               888                   \n");
  printf("    888     888                            888                      888      Y8P               888                   \n");
  printf("    888     888                            888                      888                        888                   \n");
  printf("    888     888 88888b.   .d88b.  88888b.  888888 .d8888b   .d8888b 88888b.  888  .d88b.   .d88888  .d88b.  88888b.  \n");
  printf("    888     888 888 '88b d8P  Y8b 888 '88b 888    88K      d88P'    888 '88b 888 d8P  Y8b d88' 888 d8P  Y8b 888 '88b \n");
  printf("    888     888 888  888 88888888 888  888 888    'Y8888b. 888      888  888 888 88888888 888  888 88888888 888  888 \n");
  printf("    Y88b. .d88P 888  888 Y8b.     888  888 Y88b.       X88 Y88b.    888  888 888 Y8b.     Y88b 888 Y8b.     888  888 \n");
  printf("     'Y88888P'  888  888  'Y8888  888  888  'Y888  88888P'  'Y8888P 888  888 888  'Y8888   'Y88888  'Y8888  888  888 \n");
}


//Settings
int settings(int anz_aufrufe_settings, int end_settings)
{
  char textfarbe;
  char neue_textfarbe;

  char hintergrundfarbe;
  char neue_hintergrundfarbe;

  while (end_settings == 0)
  {

    char aktiviert[6] = { 'A','k','t','i','v','\0' };
    char deaktiviert[6] = { ' ',' ','-',' ',' ','\0' };

    char eingabe_s = ' ';
    char eingabe_h_s = ' ';
    char eingabe_t_s = ' ';

    int return_to_settings = 0;
    int falsche_eingabe_hintergrundfabe = 0;
    int falsche_eingabe_textfarbe = 0;

    system("cls");
    printf("\n  Einstellungen:\n\n");
    printf("  Hintergrundfarbe = 1\n");
    printf("  Textfarbe        = 2\n\n");
    printf("  Entwicklermodus  = 3\n");
    printf("  Grafik           = 4\n\n\n");
    printf("  Zur\x81""ck           = 5\n");
    printf("  (1/2/3/4/5) ");

    scanf_s(" %c", &eingabe_s, 1);

    //Hintergrundfarbe
    if (eingabe_s == '1' || eingabe_s == 'H' || eingabe_s == 'h')
    {
      while (return_to_settings == 0)
      {
        system("cls");

        //Engine Für Aktiv Anzeige
        //Alles wird Deaktiviert
        char schwarz_h[6] = { ' ',' ','-',' ',' ','\0' };//Alternativ auch: schwarz_h = deaktiviert; 
        char grau_h[6] =    { ' ',' ','-',' ',' ','\0' };
        char weiss_h[6] =   { ' ',' ','-',' ',' ','\0' };
        char grün_h[6] =    { ' ',' ','-',' ',' ','\0' };
        char blau_h[6] =    { ' ',' ','-',' ',' ','\0' };
        char rot_h[6] =     { ' ',' ','-',' ',' ','\0' };

        //Wenn Erstesmal dann: Standart F = Weiss/0 = Schwarz
        if (anz_aufrufe_settings == 0)
        {
          hintergrundfarbe = '0';  // 1. Zeichen
          textfarbe = 'F';         // 2. Zeichen
          strcpy_s(schwarz_h, aktiviert);//Schwarz Hintergrund = aktiv
        }

        //Sortierung ob Schwarz/Grau/Weiss/Grün/Blau/Rot = aktiv?
        else if (hintergrundfarbe == '0') strcpy_s(schwarz_h, aktiviert);
        else if (hintergrundfarbe == '8') strcpy_s(grau_h, aktiviert);
        else if (hintergrundfarbe == 'F') strcpy_s(weiss_h, aktiviert);
        else if (hintergrundfarbe == '2') strcpy_s(grün_h, aktiviert);
        else if (hintergrundfarbe == '1') strcpy_s(blau_h, aktiviert);
        else if (hintergrundfarbe == '4') strcpy_s(rot_h, aktiviert);

        falsche_eingabe_hintergrundfabe = 1; //Aktivierung/Reaktivierung der Schlaufe
        if (return_to_settings == 1) falsche_eingabe_hintergrundfabe = 0; //Wenn zurück dann zurück
        
        while (falsche_eingabe_hintergrundfabe == 1)
        {

          printf("\n  Hintergrundfarbe:\n\n");
          printf("  Regeln: \n");
          printf("  Die Hintergrundfarbe und die Textfarbe k\x94nnen nicht gleich sein. \n");
          printf("  Nur eine Farbe kann [%s] sein.\n\n\n", aktiviert);

          //Farben die zur Auswahl stehen (kann noch mehr dazu kommen)
          printf("  Schwarz = 1  [%s]\n", schwarz_h);
          printf("  Grau    = 2  [%s]\n", grau_h);
          printf("  Weiss   = 3  [%s]\n", weiss_h);
          printf("  Gr\x81n    = 4  [%s]\n", grün_h);
          printf("  Blau    = 5  [%s]\n", blau_h);
          printf("  Rot     = 6  [%s]\n\n", rot_h);

          printf("  Zur\x81""ck  = 7\n");
          printf("  (1/2/3/4/5/6/7) ");
          scanf_s(" %c", &eingabe_h_s, 1);

          //Converter von Eingabe_Hintergrundfarbe_Settings (eingabe_h_s) zu Textfarbenzeichen wie es in der CMD ist
          switch (eingabe_h_s)
          {
          case '1':
            falsche_eingabe_hintergrundfabe = 0;
            neue_hintergrundfarbe = '0';//Schwarz
            break;
          case '2':
            falsche_eingabe_hintergrundfabe = 0;
            neue_hintergrundfarbe = '8';//Grau
            break;
          case '3':
            falsche_eingabe_hintergrundfabe = 0;
            neue_hintergrundfarbe = 'F';//Weiss
            break;
          case '4':
            falsche_eingabe_hintergrundfabe = 0;
            neue_hintergrundfarbe = '2';//Grün
            break;
          case '5':
            falsche_eingabe_hintergrundfabe = 0;
            neue_hintergrundfarbe = '1';//Blau
            break;
          case '6':
            falsche_eingabe_hintergrundfabe = 0;
            neue_hintergrundfarbe = '4';//Rot
            break;
          case '7':
            falsche_eingabe_hintergrundfabe = 0;
            return_to_settings = 1;//Zurück
            break;
          default:
            falsche_eingabe_hintergrundfabe = 1;

            printf("\n  Falsche Eingabe");
            system("timeout 1 >nul");
            system("cls");
          }

          //Wenn Eingegebene Hintergrundfarbe und Textfarbe gleich sind
          if (neue_hintergrundfarbe == textfarbe)
          {
            falsche_eingabe_hintergrundfabe = 1;
            printf("\n  Die Hintergrundfarbe und die Textfarbe k\x94nnen nicht gleich sein. ");
            system("timeout 2 >nul");
          }
          else
          {
            //Aufruf zur farbmatrix
            hintergrundfarbe = neue_hintergrundfarbe;
            farbmatrix(hintergrundfarbe, textfarbe);
          }
          system("cls");
          anz_aufrufe_settings++;//Erster durchgang ++
        }
        
        //Hintergrundfarbe anzeige von Aktiv 
        switch (hintergrundfarbe)
        {
        case '0':
          strcpy_s(schwarz_h, aktiviert);//Schwarz
          break;
        case '8':
          strcpy_s(grau_h, aktiviert);//Grau
          break;
        case 'F':
          strcpy_s(weiss_h, aktiviert);//Weiss
          break;
        case '2':
          strcpy_s(grün_h, aktiviert);//Grün
          break;
        case '1':
          strcpy_s(blau_h, aktiviert);//Blau
          break;
        case '4':
          strcpy_s(rot_h, aktiviert);//Rot
          break;
        }
      }
    }
    //Textfarbe bassiert auf Code von Hintergrundfarbe
    else if (eingabe_s == '2' || eingabe_s == 'T' || eingabe_s == 't')
    {
    while (return_to_settings == 0)
    {
      system("cls");
      //Engine Für Aktiv Anzeige
      //Alles wird Deaktiviert
      char schwarz_t[6] = { ' ',' ','-',' ',' ','\0' };//Alternativ auch: schwarz_t = deaktiviert; 
      char grau_t[6] = { ' ',' ','-',' ',' ','\0' };
      char weiss_t[6] = { ' ',' ','-',' ',' ','\0' };
      char grün_t[6] = { ' ',' ','-',' ',' ','\0' };
      char blau_t[6] = { ' ',' ','-',' ',' ','\0' };
      char rot_t[6] = { ' ',' ','-',' ',' ','\0' };

      //Wenn Erstesmal dann: Standart F = Weiss/0 = Schwarz
      if (anz_aufrufe_settings == 0)
      {
        hintergrundfarbe = '0';  // 1. Zeichen
        textfarbe = 'F';         // 2. Zeichen
        strcpy_s(weiss_t, aktiviert);//Schwarz Hintergrund = aktiv
      }

      //Sortierung ob Schwarz/Grau/Weiss/Grün/Blau/Rot = aktiv?
      else if (textfarbe == '0') strcpy_s(schwarz_t, aktiviert);
      else if (textfarbe == '8') strcpy_s(grau_t, aktiviert);
      else if (textfarbe == 'F') strcpy_s(weiss_t, aktiviert);
      else if (textfarbe == '2') strcpy_s(grün_t, aktiviert);
      else if (textfarbe == '1') strcpy_s(blau_t, aktiviert);
      else if (textfarbe == '4') strcpy_s(rot_t, aktiviert);

      falsche_eingabe_textfarbe = 1; //Aktivierung/Reaktivierung der Schlaufe
      if (return_to_settings == 1) falsche_eingabe_textfarbe = 0; //Wenn zurück dann zurück

      while (falsche_eingabe_textfarbe == 1)
      {

        printf("\n  Textfarbe:\n\n");
        printf("  Regeln: \n");
        printf("  Die Textfarbe und die Hintergrundfarbe k\x94nnen nicht gleich sein. \n");
        printf("  Nur eine Farbe kann [%s] sein.\n\n\n", aktiviert);

        //Farben die zur Auswahl stehen (kann noch mehr dazu kommen)
        printf("  Schwarz = 1  [%s]\n", schwarz_t);
        printf("  Grau    = 2  [%s]\n", grau_t);
        printf("  Weiss   = 3  [%s]\n", weiss_t);
        printf("  Gr\x81n    = 4  [%s]\n", grün_t);
        printf("  Blau    = 5  [%s]\n", blau_t);
        printf("  Rot     = 6  [%s]\n\n", rot_t);

        printf("  Zur\x81""ck  = 7\n");
        printf("  (1/2/3/4/5/6/7) ");
        scanf_s(" %c", &eingabe_t_s, 1);

        //Converter von Eingabe_Textfarbe_Settings (eingabe_t_s) zu Textfarbenzeichen wie es in der CMD ist
        switch (eingabe_t_s)
        {
        case '1':
          falsche_eingabe_textfarbe = 0;
          neue_textfarbe = '0';//Schwarz
          break;
        case '2':
          falsche_eingabe_textfarbe = 0;
          neue_textfarbe = '8';//Grau
          break;
        case '3':
          falsche_eingabe_textfarbe = 0;
          neue_textfarbe = 'F';//Weiss
          break;
        case '4':
          falsche_eingabe_textfarbe = 0;
          neue_textfarbe = '2';//Grün
          break;
        case '5':
          falsche_eingabe_textfarbe = 0;
          neue_textfarbe = '1';//Blau
          break;
        case '6':
          falsche_eingabe_textfarbe = 0;
          neue_textfarbe = '4';//Rot
          break;
        case '7':
          falsche_eingabe_textfarbe = 0;
          return_to_settings = 1;//Zurück

          break;
        default:
          falsche_eingabe_textfarbe = 1;
          printf("\n  Falsche Eingabe");
          system("timeout 2 >nul");
          system("cls");
        }

        //Wenn Eingegebene Hintergrundfarbe und Textfarbe gleich sind
        if (neue_textfarbe == hintergrundfarbe)
        {
          falsche_eingabe_textfarbe = 1;
          printf("\n  Die Textfarbe und die Hintergrundfarbe k\x94nnen nicht gleich sein. ");
          system("timeout 3 >nul");
        }
        else
        {
          //Aufruf zur farbmatrix
          textfarbe = neue_textfarbe;
          farbmatrix(hintergrundfarbe, textfarbe);
        }

        system("cls");
        anz_aufrufe_settings++;//Erster durchgang ++
      }

      //Hintergrundfarbe anzeige von Aktiv 
      switch (textfarbe)
      {
      case '0':
        strcpy_s(schwarz_t, aktiviert);//Schwarz
        break;
      case '8':
        strcpy_s(grau_t, aktiviert);//Grau
        break;
      case 'F':
        strcpy_s(weiss_t, aktiviert);//Weiss
        break;
      case '2':
        strcpy_s(grün_t, aktiviert);//Grün
        break;
      case '1':
        strcpy_s(blau_t, aktiviert);//Blau
        break;
      case '4':
        strcpy_s(rot_t, aktiviert);//Rot
        break;
      }
    }
    }
    //Entwicklermodus
    else if (eingabe_s == '3' || eingabe_s == 'E' || eingabe_s == 'e')
    {

    }
    //Grafik
    else if (eingabe_s == '4' || eingabe_s == 'G' || eingabe_s == 'g')
    {

    }
    else if (eingabe_s == '5' || eingabe_s == 'Z' || eingabe_s == 'z') end_settings = 1;
    else 
    {
    printf("\n  Falsche Eingabe");
    system("timeout 1 >nul");
    system("cls");
    }
  } //falsche eingabe !

  return 0;
}
//Fabmatrix wird von Settings abgeruffen
int farbmatrix(char hintergrundfarbe, char textfarbe)
{
  //Alles mit schwarzem Hintergrund
  if (hintergrundfarbe == '0' && textfarbe == 'F') system("color 0F");
  else if (hintergrundfarbe == '0' && textfarbe == '8') system("color 08");
  else if (hintergrundfarbe == '0' && textfarbe == '2') system("color 02");
  else if (hintergrundfarbe == '0' && textfarbe == '4') system("color 04");
  else if (hintergrundfarbe == '0' && textfarbe == '1') system("color 01");

  //Alles mit grauem Hintergrund
  else if (hintergrundfarbe == '8' && textfarbe == '0') system("color 80");
  else if (hintergrundfarbe == '8' && textfarbe == 'F') system("color 8F");
  else if (hintergrundfarbe == '8' && textfarbe == '2') system("color 82");
  else if (hintergrundfarbe == '8' && textfarbe == '1') system("color 81");
  else if (hintergrundfarbe == '8' && textfarbe == '4') system("color 84");

  //Alles mit weissem Hintergrund
  else if (hintergrundfarbe == 'F' && textfarbe == '0') system("color F0");
  else if (hintergrundfarbe == 'F' && textfarbe == '8') system("color F8");
  else if (hintergrundfarbe == 'F' && textfarbe == '2') system("color F2");
  else if (hintergrundfarbe == 'F' && textfarbe == '1') system("color F1");
  else if (hintergrundfarbe == 'F' && textfarbe == '4') system("color F4");

  //Alles mit Grünem Hintergrund
  else if (hintergrundfarbe == '2' && textfarbe == '0') system("color 20");
  else if (hintergrundfarbe == '2' && textfarbe == '8') system("color 28");
  else if (hintergrundfarbe == '2' && textfarbe == 'F') system("color 2F");
  else if (hintergrundfarbe == '2' && textfarbe == '1') system("color 21");
  else if (hintergrundfarbe == '2' && textfarbe == '4') system("color 24");

  //Alles mit Blauem Hintergrund
  else if (hintergrundfarbe == '1' && textfarbe == '0') system("color 10");
  else if (hintergrundfarbe == '1' && textfarbe == '8') system("color 18");
  else if (hintergrundfarbe == '1' && textfarbe == 'F') system("color 1F");
  else if (hintergrundfarbe == '1' && textfarbe == '2') system("color 12");
  else if (hintergrundfarbe == '1' && textfarbe == '4') system("color 14");

  //Alles mit Rotem Hintergrund
  else if (hintergrundfarbe == '4' && textfarbe == '0') system("color 40");
  else if (hintergrundfarbe == '4' && textfarbe == '8') system("color 48");
  else if (hintergrundfarbe == '4' && textfarbe == 'F') system("color 4F");
  else if (hintergrundfarbe == '4' && textfarbe == '2') system("color 42");
  else if (hintergrundfarbe == '4' && textfarbe == '1') system("color 41");

  //Fertig vlt weitere Farben...
  return 0;
}
