using System;
using System.Collections.Generic;
using System.Diagnostics; //Neuer namespace für Stoppuhr //////////////////////////////////

namespace ArrayAlgorithmus
{
  class Teil2
  {
    static void Main(string[] args)
    {
      const int Anzahl = 10000;
      List<int> Wertearray = new List<int>();
      Random Zufall        = new Random();
      Stopwatch Stoppuhr = new Stopwatch(); //Stoppuhr ////////////////////////////////////

      //Array mit Zufallszahlen füllen
      for (int iWert = 0; iWert < Anzahl; iWert++) Wertearray.Add(Zufall.Next(10, 99));

      Stoppuhr.Start(); // Startet die Stoppuhr ///////////////////////////////////////////

      //Array sortieren
      for (int iWert = 0; iWert < Wertearray.Count - 1; iWert++)
      {
        for (int jWert = iWert + 1; jWert < Wertearray.Count; jWert++)
        {
          if (Wertearray[iWert] > Wertearray[jWert])
          {
            int Tmp = Wertearray[iWert];
            Wertearray[iWert] = Wertearray[jWert];
            Wertearray[jWert] = Tmp;
          }
        }
      }

      Stoppuhr.Stop(); // Stoppt die Stoppuhr /////////////////////////////////////////////

      //Array ausgeben
      foreach (int Wert in Wertearray) Console.Write("{0} ", Wert);
      Console.WriteLine();

      //Stoppuhr ausgeben /////////////////////////////////////////////////////////////////
      double dauer = Stoppuhr.ElapsedMilliseconds / (double)Stopwatch.Frequency;
      Console.WriteLine("Sortierdauer: {0} Werte in {1} ms ({2} Ticks)",
        Wertearray.Count,
        Stoppuhr.ElapsedMilliseconds,
        Stoppuhr.ElapsedTicks);

      //Ende
      Console.Write("Drücke eine Tatse..."); while (!Console.KeyAvailable) ;
      Console.ReadKey();
    }
  }
}
