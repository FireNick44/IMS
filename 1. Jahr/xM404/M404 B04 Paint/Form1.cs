using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M404_B04_Paint
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    //Aufgabe 1
    //private void button1_Click(object sender, EventArgs e)
    //{
    //  Graphics g = this.CreateGraphics();
    //  Pen myPP = new Pen(Color.Green);
    //  g.DrawLine(myPP, 10, 10, 250, 250);
  
    //  Pen myPPP = new Pen(Color.Red);
    //  g.DrawEllipse(myPPP, 10, 10, 250, 250);
    //}

      private void button1_Click(object sender, EventArgs e)
      {
        ColorDialog cdlg = new ColorDialog();
        if (DialogResult.OK == cdlg.ShowDialog())
          lblFarbe.BackColor = cdlg.Color;
      }
//Die Struktur, welche die zu speichernden Daten eines Kreises repräsentiert
struct struKreis
    {
      public int x; //X-Wert des MittelPunktes
      public int y; //Y-Wert des MittelPunktes
      public int Durchmesser; //Durchmesser des Kreises
      public Color farbe; //Farbe des Kreises
    }
    //Dynamisches Datenfeld, das Variablen der Struktur struKreis aufnehmen kann
    List<struKreis> m_kreise = new List<struKreis>();
    private void OnMouseDown(object sender, MouseEventArgs e)
    {
      struKreis aktkreis; //Neue Variable der Struktur "stuKreis"
      aktkreis.x = e.X;
      aktkreis.y = e.Y;
      aktkreis.farbe = lblFarbe.BackColor; //Labelhintergrundfarbe als Kreisfarbe verwenden
      Random r = new Random(); //Objekt für die Erstellung von Zufallszahlen
      aktkreis.Durchmesser = r.Next(100); //Zufallswert der kleiner als 100 ist
      m_kreise.Add(aktkreis); //Strukturvariable in dynamische Liste legen
      this.Invalidate();
    }
    private void OnPaint(object sender, PaintEventArgs e)
    {
      Graphics g = this.CreateGraphics();
      for (int i = 0; i < m_kreise.Count; i++)
      {
        struKreis k = m_kreise[i];
        Pen myPen = new Pen(Color.Blue);
        g.DrawEllipse(myPen, k.x, k.y, 50, 50);
      }

    }

    private void lblFarbe_Click(object sender, EventArgs e)
    {

    }
  }
}
