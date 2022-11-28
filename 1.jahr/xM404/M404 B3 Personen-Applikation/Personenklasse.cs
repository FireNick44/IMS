using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M404_B3_Personen_Applikation
{
  class Personenklasse
  {
    //klassenV
    private static int s_AnzahlObjekte = 0;

    //instanzV
    private int m_ID;
    private string m_Name;
    private string m_Vorname;
    private int m_Alter;

    //Standart KK
    public Personenklasse()
    {
      setAlter(1);
      s_AnzahlObjekte++;
      setID(s_AnzahlObjekte);
    }

    //erweiterten KK
    public Personenklasse(string pNamen, string pVornamen, int pAlter)
    {
      setName(pNamen);
      setVorname(pVornamen);
      setAlter(pAlter);
      s_AnzahlObjekte++;
      setID(s_AnzahlObjekte);
    }
    private void setID(int v)
    {
      if (v < 1)
        v = 1;
      else if (v > 100)
      {
        v = 100;
      }
      m_ID = v;
    }

    public int getID()
    {
      return m_ID;
    }
    public string getName()
    {
      return m_Name;
    }
    public void setName(string v)
    {
      m_Name = v;
    }
    public string getVorname()
    {
      return m_Vorname;
    }
    public void setVorname(string v)
    {
      m_Vorname = v;
    }
    public int getAlter()
    {
      return m_Alter;
    }
    public void setAlter(int v)
    {
      if (v < 0)
        v = 0;
      else if (v > 140)
      {
        v = 140;
      }
      m_Alter = v;
    }
  }
}
