using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe05
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void button_exit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double zahl1 = 1;
      double zahl2 = 1;
      double ergebnis = 1;

      zahl1 = Convert.ToDouble(tb1.Text);//TB1 = zahl1
      zahl2 = Convert.ToDouble(tb2.Text);//TB2 = zahl2

    //  if (((Button)sender).Text== "+")
        ergebnis = zahl1 + zahl2;

      tb3.Text = ergebnis.ToString();
    }

    private void tb3_TextChanged(object sender, EventArgs e)
    {

    }

    private void button_plus_Click(object sender, EventArgs e)
    {

      double zahl1 = 1;
      double zahl2 = 1;
      double ergebnis = 1;

      zahl1 = Convert.ToDouble(tb1.Text);//TB1 = zahl1
      zahl2 = Convert.ToDouble(tb2.Text);//TB2 = zahl2

      ergebnis = zahl1 + zahl2;

      tb3.Text = ergebnis.ToString();
    }
    //private double Calculate(char c) { }

    private void button_mal_Click(object sender, EventArgs e)
    {
      double zahl1 = 1;
      double zahl2 = 1;
      double ergebnis = 1;

      zahl1 = Convert.ToDouble(tb1.Text);//TB1 = zahl1
      zahl2 = Convert.ToDouble(tb2.Text);//TB2 = zahl2

      ergebnis = zahl1 * zahl2;

      tb3.Text = ergebnis.ToString();
    }

    private void button_div_Click(object sender, EventArgs e)
    {
      double zahl1 = 1;
      double zahl2 = 1;
      double ergebnis = 1;

      zahl1 = Convert.ToDouble(tb1.Text);//TB1 = zahl1
      zahl2 = Convert.ToDouble(tb2.Text);//TB2 = zahl2

      ergebnis = zahl1 / zahl2;

      tb3.Text = ergebnis.ToString();
    }

    private void button_minus_Click(object sender, EventArgs e)
    {
      double zahl1 = 1;
      double zahl2 = 1;
      double ergebnis = 1;

      zahl1 = Convert.ToDouble(tb1.Text);//TB1 = zahl1
      zahl2 = Convert.ToDouble(tb2.Text);//TB2 = zahl2

      ergebnis = zahl1 - zahl2;

      tb3.Text = ergebnis.ToString();
    }
  }
}
