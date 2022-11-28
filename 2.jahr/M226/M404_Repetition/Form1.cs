using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M404_Repetition
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void b_static_Click(object sender, EventArgs e)
    {
      double b = Convert.ToDouble(txtB_Breite.Text);
      double l = Convert.ToDouble(txtB_Länge.Text);

      double f = Rechteck.getFläche(b, l);

      txtB_Fläche.Text = Convert.ToString(f);

    }

    private void b_object_Click(object sender, EventArgs e)
    {
      Rechteck r = new Rechteck();

      double b = 0;
      double l = 0;
      b = Convert.ToDouble(txtB_Breite.Text);
      l = Convert.ToDouble(txtB_Länge.Text);
      
      r.setSeiteA(b);
      r.setSeiteB(l);

      txtB_Fläche.Text = Convert.ToString(r.getFläche());

    }
  }
}
