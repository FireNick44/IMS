using System;

namespace M404_Objektorientiert_Kreis
{
  class Program
  {
    static void Main(string[] args)
    {
      Kreis Kreis = new Kreis(); //Somit wird die Klasse Kreis unter Kreis aufgerufen

      Console.WriteLine("XXXXXXXXXXXXXXXXXX DRUF XXXXXXXXXXXXXXXXXX Version 1.0");
      Console.WriteLine("Welche Information wissen Sie:");
      Console.WriteLine("D = Durchmesser");
      Console.WriteLine("R = Radius");
      Console.WriteLine("U = Umfang");
      Console.WriteLine("F = Fläche"); 
      string eingabe = Console.ReadLine();
         

       if(eingabe == "D")
      {
        Console.WriteLine("Geben sie den Durchmesser ein:");
        eingabe = Console.ReadLine();
        Kreis.setDurchmesser(Convert.ToDouble(eingabe));
      }
       else if(eingabe == "R")
      {
        Console.WriteLine("Geben sie den Radius ein:");
        eingabe = Console.ReadLine();
        Kreis.setRadius(Convert.ToDouble(eingabe));
      }
       else if(eingabe == "U")
      {
        Console.WriteLine("Geben sie den Umfang ein:");
        eingabe = Console.ReadLine();
        Kreis.setUmfang(Convert.ToDouble(eingabe));
      }
       else if(eingabe == "F")
       {
        Console.WriteLine("Geben sie die Fläche ein:");
        eingabe = Console.ReadLine();
        Kreis.setFlaeche(Convert.ToDouble(eingabe));
       }
       else
      {
        Console.WriteLine("Geben Sie eine Eingabe ein: (D / R)");
        Console.ReadKey(); //Endet das Programm mit einer Tasteneingabe.}

      }

      double Flaeche, Radius, Durchmesser, Umfang;
      Durchmesser = Kreis.getDurchmesser();
      Radius = Kreis.getRadius();
      Flaeche = Kreis.getFlache();
      Umfang = Kreis.getUmfang();

      Console.WriteLine("");
      Console.WriteLine("Durchmesser = {0}", Durchmesser); // Befehl um eine Ausagbe mit Variabel zu verknüpfen
      Console.WriteLine("Radius      = {0}", Radius);
      Console.WriteLine("Umfang      = {0}", Umfang);
      Console.WriteLine("Fläche      = {0}", Flaeche);

      Console.ReadKey(); //Endet mit einer Taste.
    }
  }
}
