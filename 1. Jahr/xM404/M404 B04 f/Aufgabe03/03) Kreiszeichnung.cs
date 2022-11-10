using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe03
{
  public partial class Kreiszeichnung : Form
  {
    public Kreiszeichnung()
    {
      InitializeComponent();
    }

    private void OnFarbeClick(object sender, EventArgs e)
    {
      ColorDialog cdlg = new ColorDialog();
      if (DialogResult.OK == cdlg.ShowDialog())
      {
        lblFarbe.BackColor = cdlg.Color;
      }
    }

    // Die Struktur, welche die zu speichernden Daten eines Kreises repräsentiert.
    struct struKreis
    {
      public int x;
      public int y;
      public int Durchmesser;
      public Color farbe;
    }

    // Dynamisches Datenfeld, welches Variablen der Struktur struKreis aufnehmen kann.
    List<struKreis> m_kreise = new List<struKreis>();

    private void OnMouseDown(object sender, MouseEventArgs e)
    {
      struKreis aktkreis;
      aktkreis.x = e.X;
      aktkreis.y = e.Y;
      aktkreis.farbe = lblFarbe.BackColor;
      Random r = new Random();
      aktkreis.Durchmesser = r.Next(100);
      m_kreise.Add(aktkreis);                                                     //
      this.Invalidate();                                                          // Neuzeichnen Onpaint

    }

    private void OnPaint(object sender, PaintEventArgs e)
    {

      Graphics g = this.CreateGraphics();
      for (int i = 0; i < m_kreise.Count; i++)
      {
        struKreis k = m_kreise[i];
        Pen myPen = new Pen(k.farbe);
        g.DrawEllipse(myPen, k.x-k.Durchmesser/2, k.y-k.Durchmesser / 2, k.Durchmesser, k.Durchmesser);
      }

    }
  } // Ende Klasse
} // Ende Namespace
