using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe01
{
  class Program1
  {
    static void Main(string[] args)
    {
      const int Anzahl = 10;
      List<int> Werte = new List<int>();
      Random Zufall = new Random();

      //Am meisten komprimiert
      for (int Index = 0; Index < Anzahl; Index++)
        Werte.Add(Zufall.Next(0, 99));

      // Zufall für folgende Varianten
      /*Werte.Add(Zufall.Next(0, 99));
      Werte.Add(Zufall.Next(0, 99));
      Werte.Add(Zufall.Next(0, 99));
      */
      for (int Index = 0; Index < Werte.Count; Index++)
      {
        Console.WriteLine("Zahl = {0}", Werte[Index]);
      }
      Console.WriteLine("HALT STOP");
      while (!Console.KeyAvailable) ;


      foreach (int Zahl in Werte)
        Console.WriteLine("Zahl = {0}", Werte);
      Console.WriteLine("HALT STOP");
      while (!Console.KeyAvailable) ;

      Console.WriteLine("Zahl = {0}", Werte[0]);
      Console.WriteLine("Zahl = {0}", Werte[1]);
      Console.WriteLine("Zahl = {0}", Werte[2]);
      Console.WriteLine("HALT STOP"); while (!Console.KeyAvailable) ;
      Console.ReadKey();

    }
  }
}
