using System;
using System.Collections.Generic;
using System.Text;

namespace M404_Objektorientiert_Kreis
{
  class Kreis
  {
    private double m_Durchmesser; //Standart Konstruktor für Durchmesser 

    public Kreis() //Methode 
    {
      m_Durchmesser = 0;
    }
    /*public double setDurchmesser() //NachRadius
{
     m_Durchmesser = eingabetest;
     //So in etwa funktioniert die set variable
     //(mit set kann man von ausserhalb die membervariabeln bearbeiten)

}*/

    //Get dings
    public double getDurchmesser() //NachRadius
    {
      return m_Durchmesser;
    }
    public double getUmfang() //NachDurchmesser
    {
      return m_Durchmesser * Math.PI;
    }
    public double getFlache() //NachDurchmesser
    {
      return Math.Pow(m_Durchmesser, 2) * Math.PI / 4;
    }
    public double getRadius() //NachUmfang und Fläche
    {
      return m_Durchmesser / 2;
    }


    //Set dings 
    public void setDurchmesser(double d)
    {
      m_Durchmesser = d;
      //Bedingungen
    }
    public void setUmfang(double u)
    {
      m_Durchmesser = u / Math.PI;
    }
    public void setFlaeche(double f)
    {
      m_Durchmesser = Math.Sqrt(4 * f / Math.PI);
    }
    public void setRadius(double r)
    {
      m_Durchmesser = r * 2; 
      
    }
  }
}
