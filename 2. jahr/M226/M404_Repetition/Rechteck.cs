using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M404_Repetition
{
  class Rechteck
  {
    //private double m_A; //Standart Konstruktor für Durchmesser 
    //private double m_B; //Standart Konstruktor für Durchmesser 

    public double m_A { get; set; }
    public double m_B { get; set; }

    //prop TAB TAB
    //ctor TAB TAB

    public Rechteck() //Methode 
    {
      m_A = 0;
      m_B = 0;
    }

    //Get dings
    public double getFläche() //NachRadius
    {
      return m_A * m_B;
    }
    static public double getFläche(double a, double b) //NachRadius
    {
      return a*b;
    }


    //Set dings 
    public void setRechteck(double a, double b)
    {
      m_A = a;
      m_B = b;
      //Bedingungen
    }
    public void setSeiteA(double a)
    {
      m_A = a;
      //Bedingungen
    }
    public void setSeiteB(double b)
    {
      m_B = b;
      //Bedingungen
    }
  }
}
