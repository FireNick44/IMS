using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe02
{
  class Program2
  {
    static void ArrayOutput(List<int> liste)
    {
      foreach (int Zahl in liste)
        Console.WriteLine("Zahl = {0}", Zahl);
    }
    static void Main(string[] args)
    {
      const int Anzahl = 10;
      List<int> Werte = new List<int>();
      Random Zufall = new Random();

      //Am meisten komprimiert
      for (int Index = 0; Index < Anzahl; Index++)
        Werte.Add(Zufall.Next(0, 99));

      ArrayOutput(Werte);

      Console.ReadKey();



      //Unsolved
    }
  }
}
