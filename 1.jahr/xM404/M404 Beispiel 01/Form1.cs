using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M404_Beispiel_01
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void VerdoppelnClick(object sender, EventArgs e)
    {
      //Variable definieren
      double eingabeZahl = 0;
      double resultat = 0;

      //Eingabe einlesen
      eingabeZahl = Convert.ToDouble(tbxEingabe.Text);

      //Berechnung
      resultat = eingabeZahl * 2;

      //Ausgabe des Resultats
      tbxAusgabe.Text = resultat.ToString();

    }
  }
}
