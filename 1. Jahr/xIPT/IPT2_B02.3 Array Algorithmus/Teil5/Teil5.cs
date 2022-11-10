using System;
using System.Collections.Generic;
using System.Diagnostics;


/// <summary>
/// MEINE LÖSUNG
/// </summary>
namespace Teil2
{
  class Teil5

  {
    static void Main(string[] args)
    {
      int[] Testreihe = { 100, 1000, 10000, 30000, 50000 }; /////////////////////////////////////
      List<int> Wertearray = new List<int>();
      List<int> WertearrayAuto = new List<int>();
      Random Zufall = new Random();
      Stopwatch StoppuhrManuel = new Stopwatch();
      Stopwatch StoppuhrAutomatisch = new Stopwatch(); /////////////////////////////////////////

      foreach (int Anzahl in Testreihe)
      {

        Wertearray.Clear(); ////////////////////////////////////////////////////////

        //Array mit Zufallszahlen füllen
        for (int iWert = 0; iWert < Anzahl; iWert++) Wertearray.Add(Zufall.Next(10, 99));

        WertearrayAuto.Clear();
        WertearrayAuto.AddRange(Wertearray);

        StoppuhrManuel.Start();

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

        StoppuhrManuel.Stop();

        //array über List methode sortieren
        StoppuhrAutomatisch.Restart();
        WertearrayAuto.Sort();
        StoppuhrAutomatisch.Stop();

        /*
        //Array ausgeben
        foreach (int Wert in Wertearray) Console.Write("{0} ", Wert);
        Console.WriteLine();
        */

        //Stoppuhr ausgeben 
        double dauer = StoppuhrManuel.ElapsedMilliseconds / (double)Stopwatch.Frequency;
        Console.WriteLine("Sortierdauer: {0,9} Werte in {1,12:0.000} ms ({2} Ticks und Sortierdauer: {3,9} Werte in {4,12:0.000} ms ({5} Ticks)", //////////////////Wurde geändert für werte darstellung
          Wertearray.Count,
          StoppuhrManuel.ElapsedMilliseconds / (double)Stopwatch.Frequency * 1000.0,
          StoppuhrManuel.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0
          WertearrayAuto.Count,
          StoppuhrAutomatisch.ElapsedMilliseconds / (double)Stopwatch.Frequency * 1000.0,
          StoppuhrAutomatisch.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0);
      }

      //Ende
      Console.Write("Drücke eine Tatse..."); while (!Console.KeyAvailable) ;
      Console.ReadKey();
    }
  }
}
