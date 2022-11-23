using System;
using System.Collections.Generic;
using System.Collections;

namespace IPT_Beispiel_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      //const int Anzahl = 10;

      //int[] Werte = new int[300000000]; //Für Statische ---> Lenght (Werte.Lenght)
      //ArrayList Werte = new ArrayList();  //Für Generische---> Count (Werte.Count)
      Random Zufall = new Random(); // random gen

      List<int> Werte = new List<int>();
      for (int Index = 0; Index < 100000; Index++)
                                 //Werte.Count; / Werte.Lenght; 
      {
        Werte.Add(Zufall.Next(10, 100));
        /*if (!Werte.Contains(Zahl)) Werte.Add(Zahl);
        
        Werte[Index] = Zufall.Next(10, 100); //random gen statisch*/
      }


      Werte.Sort();
      //Werte.Add("Gugus") //man kann 

      Console.WriteLine("Array mit {0} Zahlen: ", Werte.Count);
      int Nummer = 1;
      foreach (int Zahl in Werte)
      {
        Console.WriteLine("{0}. Zahl = {1}", Nummer++,Zahl);
      }

      Console.Write("Drücken Sie eine Taste");
      //Console.ReadLine(); //Endet mit Enter auf.
      Console.ReadKey(); //Endet mit einer Taste.
    }
  }
}
