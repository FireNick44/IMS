using System;
using System.Collections.Generic;
using System.Diagnostics;


/// <summary>
/// MEINE LÖSUNG
/// </summary>
namespace Teil2
{
  class Teil4

  {
    static void Main(string[] args)
    {
      int[] Testreihe = { 100, 1000, 10000, 30000, 50000 }; /////////////////////////////////////
      List<int> Wertearray = new List<int>();
      Random Zufall = new Random();
      Stopwatch Stoppuhr = new Stopwatch();

      foreach (int Anzahl in Testreihe)
      {

        Wertearray.Clear(); ////////////////////////////////////////////////////////

        //Array mit Zufallszahlen füllen
        for (int iWert = 0; iWert < Anzahl; iWert++) Wertearray.Add(Zufall.Next(10, 99));

        Stoppuhr.Start();

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

        Stoppuhr.Stop();

        /*
        //Array ausgeben
        foreach (int Wert in Wertearray) Console.Write("{0} ", Wert);
        Console.WriteLine();
        */

        //Stoppuhr ausgeben 
        double dauer = Stoppuhr.ElapsedMilliseconds / (double)Stopwatch.Frequency;
        Console.WriteLine("Sortierdauer: {0,9} Werte in {1,12:0.000} ms ({2} Ticks)", //////////////////Wurde geändert für werte darstellung
          Wertearray.Count,
          Stoppuhr.ElapsedMilliseconds,
          Stoppuhr.ElapsedTicks);
      }

      //Ende
      Console.Write("Drücke eine Tatse..."); while (!Console.KeyAvailable) ;
      Console.ReadKey();
    }
  }
}
