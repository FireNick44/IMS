using System;
using System.Windows.Forms;

namespace PersonenAppV2
{
  public class Person
  {
    //CONSTANTE WERTE
    static int EintrittsJahrMIN = 1975;
    static double SalaerMIN = 0.00;
    static double SalaerMAX = 99999.95;

    //Membervariabeln
    int m_EintrittsJahr = 0;
    //ctor TAB TAB
    //prop TAB TAB

    public Person()
    {
      PersonNr       = -1;
      Anrede         = "Frau";
      Vorname        = "";
      Plz            = "6000";
      Ort            = "Luzern";
      EintrittsJahr  = 2021;
      Salaer         = 5000.00;
      Pensum         = 100;
    }

    public Person(int value)
    {
      PersonNr = value;
    }

    public Person(int var, string anr, string vor, string nam)
    {
      PersonNr = var;
      Anrede = anr;
      Vorname = vor;
      Name = nam;
    }

    public int PersonNr { get; private set; }
    public string Anrede { get; set; }
    public string Name { get; set; }
    public string Vorname { get; set; }
    public string Plz { get; set; }
    public string Ort { get; set; }
    public int EintrittsJahr
    {
      get
      {
        return m_EintrittsJahr;
      }
      set
      {
        if (value <= EintrittsJahrMIN)
        {
          EintrittsJahrMIN = value;
          MessageBox.Show("Das Eintrittsjahr muss im Bereich 1975 bis 2021 sein!");
        }
      }
    }
    public double Salaer 
    {
      get
      {
        return Salaer;
      }
      set
      {
        if (value <= SalaerMIN || value >= SalaerMAX)
        {
          value = 1;
          MessageBox.Show("Der Salaer muss im Bereich von 0 und 99'999.95 sein!");
        }
      }
    }
    public double Pensum { get; set; }

  }
}
