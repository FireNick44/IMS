using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT2_B02_4
{
  class Person {
    public string Nachname;
    public string Vorname;
    public int Jahrgang;

    public Person(string nachname, string vorname, int jg) {
      Nachname = nachname;
      Vorname = vorname;
      Jahrgang = jg;
    }
    public override string ToString()
    {
      return Vorname + " " + Nachname + ", " + Jahrgang.ToString();
        }
  }

  class Program
  {
    public static int PersonenCompare (Person person1, Person person2) {
      int Compare = String.Compare(person1.Nachname, person2.Nachname);
      if (Compare == 0) Compare = String.Compare(person1.Nachname, person2.Nachname);
      if (Compare == 0) Compare = String.Compare(person1.Nachname, person2.Nachname);
      return Compare;
    }
    static void Main(string[] args)
    {
      List<Person> Einwohner = new List<Person>(); //macht das Ganze Objekt in die klasse (Person Klasse in Einwohner Objekt)

      Einwohner.Add(new Person("Muster", "Hans", 2010));
      Einwohner.Add(new Person("Superman", "Klark", 0101));
      Einwohner.Add(new Person("Supremegirl", "Anal", 9999));

      Einwohner.Sort(PersonenCompare);

      foreach (Person Mensch in Einwohner)
        Console.WriteLine("{0}", Mensch);

      //Console.WriteLine("{0} {1}, {2}", Mensch.Vorname, Mensch.Nachname, Mensch.Jahrgang);


      //Ende 
      Console.Write("Drücke zum beenden");
      Console.ReadKey();
    }
  }
}
