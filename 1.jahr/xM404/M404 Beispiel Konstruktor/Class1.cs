using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M404_Beispiel_Konstruktor
{
  class Kreis
  {
    //Membervariable
    private double m_Durchmesser;

    public Kreis()
    {
      m_Durchmesser = d;
    }
    //Methode
    public double getDurchmesser;



    public getUmfang()
    {
      return m_Umfang * Math.PI;
    }

    public double get Flaeche()
    {
      return Math.Pow(m_Durchmesser);
    }

    //Notes zu Konstruktor
    Kreis kreis1 = new Kreis();
    kreis1.setDurchmesser(10);

  }

}
