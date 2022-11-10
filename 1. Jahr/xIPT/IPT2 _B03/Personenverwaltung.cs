using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT2_B03
{
  [Serializable]
  class Personenverwaltung
  {
    //Private 
    private string m_vname;
    private string m_nachname;
    private string m_strasse;
    private string m_plz;
    private string m_ort;
    private string m_typ;

    public string Nachname { get; set; }
    public string Vorname { get; set; }


    //standart KK

    /*public Personenverwaltung()
    {
      setvname("leer");
      getnachname("leer");
    }*/
    public Personenverwaltung()
    {
      m_vname = " ";
      m_nachname = " ";
      m_strasse = " ";
      m_plz = " ";
      m_ort = " ";
      m_typ = " ";
    }

    public Personenverwaltung(string d, string p)
    {
      setnachname(d);
      setvname(p);
    }

    public string getvname()
    {
      return m_vname;
    }
    public void setvname(string v)
    {
      m_vname = v;
    }
    public string getnachname()
    {
      return m_nachname;
    }
    public void setnachname(string v)
    {
      m_nachname = v;
    }
    public string getstrasse()
    {
      return m_strasse;
    }
    public void setstrasse(string v)
    {
      m_strasse = v;
    }
    public string getplz()
    {
      return m_plz;
    }
    public void setplz(string v)
    {
      m_plz = v;
    }
    public string getort()
    {
      return m_ort;
    }
    public void setort(string v)
    {
      m_ort = v;
    }
    public string gettyp()
    {
      return m_typ;
    }
    public void settyp(string v)
    {
      m_typ = v;
    }
  }
}
