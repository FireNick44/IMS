using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {

      double SeiteA, SeiteB, Flaeche, Umfang;

      Rechteck Rechteck1 = new Rechteck();

      SeiteA = Convert.ToDouble(tbxSeiteA.Text);
      SeiteB = Convert.ToDouble(tbxSeiteB.Text);

      Rechteck1.setSeiteA(SeiteA);
      Rechteck1.setSeiteB(SeiteB);

      Umfang = Rechteck1.getUmfang();
      Flaeche = Rechteck1.getFlaeche();

      tbxAusgabeU.Text = Convert.ToString(Umfang);
      tbxAusgabeF.Text = Convert.ToString(Flaeche);

    }
  }
}
