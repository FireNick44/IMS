using System;
using System.Collections.Generic;


namespace IPT2_B02._3_Array_Algorithmus
{
  class Teil1
  {
    static void Main(string[] args)
    {
      const int Anzahl = 10000;
      List<int> Wertearray  = new List<int>();
      Random Zufall    = new Random();

      //Array mit Zufallszahlen füllen
      for (int iWert = 0; iWert < Anzahl; iWert++) Wertearray.Add(Zufall.Next(10, 99));

      //Array sortieren
      for (int iWert = 0; iWert < Wertearray.Count - 1; iWert++){
        for (int jWert = iWert + 1; jWert < Wertearray.Count; jWert++)
        {
          if(Wertearray[iWert] > Wertearray[jWert]) {
            int Tmp = Wertearray[iWert];
            Wertearray[iWert] = Wertearray[jWert];
            Wertearray[jWert] = Tmp;
          }
        }
      }

      //Array ausgeben
      foreach (int Wert in Wertearray) Console.Write("{0} ", Wert);
      Console.WriteLine();

      //Ende
      Console.Write("Drücke eine Tatse..."); while (!Console.KeyAvailable) ;
      Console.ReadKey();
    }
  }
}
