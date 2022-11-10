using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe04
{
  public partial class Erweiterung : Form
  {
    public Erweiterung()
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
      if (e.Button == MouseButtons.Left)
      {
        struKreis aktkreis;
        aktkreis.x = e.X;
        aktkreis.y = e.Y;
        aktkreis.farbe = lblFarbe.BackColor;
        Random r = new Random();
        aktkreis.Durchmesser = r.Next(100);
        m_kreise.Add(aktkreis);

      }

      // Lösung Aufg. 4 -----------------------------------------------------------------------------
      /*  
       
            else if (e.Button == MouseButtons.Right)
      {
            for (int i = 0; i < m_kreise.Count; i++)
            {
              struKreis k = m_kreise[i];
              int dx = Math.Abs(e.X - k.x);
              int dy = Math.Abs(e.Y - k.y);
              double Abstand = Math.Sqrt(dx * dx + dy * dy);                  // Pythagoras Regel
              if (k.Durchmesser / 2 >= Abstand)
              {
                // Treffer? --> Kreis entfernen
                m_kreise.RemoveAt(i);
              }

            }
      
      }

            //  Damit der letzte der gespeicherten Werten gelöscht wird ----------------------------
      /*  
       
            else if (e.Button == MouseButtons.Right)
      {
            for (int i = m_kreise.Count-1; i >= 0; i--)                       // Das dekrementieren 
            {
              struKreis k = m_kreise[i];
              int dx = Math.Abs(e.X - k.x);
              int dy = Math.Abs(e.Y - k.y);
              double Abstand = Math.Sqrt(dx * dx + dy * dy);                  // Pythagoras Regel
              if (k.Durchmesser / 2 >= Abstand)
              {
                // Treffer? --> Kreis entfernen
                m_kreise.RemoveAt(i);
                break;                                                        // Damit nur der letzte gelöscht wird, braucht man einen Ausbruch aus der Schleife, einen "break"
              }

            }
      
      }

       */


      // eigene Variante -----------------------------------------------------------------------------------
      /*
      else if (e.Button == MouseButtons.Right)
      {
        foreach (i in m_kreise)
        {
          struKreis k = m_kreise[i];
          int dx = Math.Abs(e.X - k.x);
          int dy = Math.Abs(e.X - k.x);
          double Abstand = Math.Sqrt
        }

        
      }

      */

      else if (e.Button == MouseButtons.Right)
      {
            for (int i = 0; i < m_kreise.Count; i++)
            {
              struKreis k = m_kreise[i];
              int dx = Math.Abs(e.X - k.x);
              int dy = Math.Abs(e.Y - k.y);
              double Abstand = Math.Sqrt(dx * dx + dy * dy);                  // Pythagoras Regel
              if (k.Durchmesser / 2 >= Abstand)
              {
                // Treffer? --> Kreis entfernen
                m_kreise.RemoveAt(i);
                i--;                                                  // Weil es ein dynamisches Array ist, rutscht jeder Satz eine Stelle nach vorne, 
              }                                                       // also i muss abnehmen, damit es den nächsten Satz mit der If-Bedingung überprüfen kann.

            }
      
      }

      this.Invalidate();                                                            // Neuzeichnen

    }

    private void OnPaint(object sender, PaintEventArgs e)
    {

      Graphics g = this.CreateGraphics();
      for (int i = 0; i < m_kreise.Count; i++)
      {
        struKreis k = m_kreise[i];
        Pen myPen = new Pen(k.farbe);
        g.DrawEllipse(myPen, k.x - k.Durchmesser / 2, k.y - k.Durchmesser / 2, k.Durchmesser, k.Durchmesser);
      }

    }
  }
}
