using System;
using System.Collections.Generic;

namespace Aufgabe04
{
  class Program4
  {
    static void ArrayOutput(List<int> liste)
    {
      bool FirstZahl = true; //Tscheggt ob es der erste lauf ist 

      Console.Write("Zahlen: ");
      foreach (int Zahl in liste)

        if (FirstZahl)
        {
          Console.Write(" {0} ", Zahl);
          FirstZahl = false;
        }
        else
          Console.Write("| {0} ", Zahl);

      Console.WriteLine();
    }

    static List<int> ArrayCreate(int Anzahl)
    {
      Random Zufall = new Random();
      List<int> Werte = new List<int>();

      do
      {
        int Zufallszahl = Zufall.Next(0, 99);
        if (!Werte.Contains(Zufallszahl)) Werte.Add(Zufallszahl);
      } while (Werte.Count < Anzahl);

      return Werte;
    }


    static void Main(string[] args)
    {
      const int Anzahl = 100;
      List<int> Werte = ArrayCreate(Anzahl);
      Werte.Sort();
      Werte.Reverse();
      ArrayOutput(Werte);

      Console.Write("Drücken irgend eine Taste...");
      while (!Console.KeyAvailable) ;
      Console.ReadKey();
    }
  }
}
