using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe
{
  class Rechteck
  {
    private double m_seiteA;
    private double m_seiteB;
    private double Flaeche;
    private double Umfang;




    public void setSeiten()
    {
      m_seiteA = 0;
      m_seiteB = 0;
    }


    public void setSeiteA(double a)
    {
      m_seiteA = a;
      if (a < 0 || a > 500)
      {
        setSeiten();
      }
    }
    public void setSeiteB(double b)
    {
      m_seiteB = b;
      if (b < 0 || b > 500)
      {
        setSeiten();
      }
    }
    public double getFlaeche() //Methode wie fläche berechnet wird
    {
      return m_seiteA * m_seiteB;
    }
    public double getUmfang() //Methode wie umfang berechnet wird
    {
      return (m_seiteB * 2) + (m_seiteA * 2);
    }
  }
}
