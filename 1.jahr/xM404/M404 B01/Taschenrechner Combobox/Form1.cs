using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe05_Kombobox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button_berechnen_Click(object sender, EventArgs e)
    {
      try
      {
        double zahl1 = 0;
        double zahl2 = 0;
        double resultat = 0;

        zahl1 = Convert.ToDouble(textBox1_zahl1.Text);
        zahl2 = Convert.ToDouble(textBox2_zahl2.Text);

        if (comboBox.Text == "Plus")
          resultat = zahl1 + zahl2;
        else if (comboBox.Text == "Minus")
          MessageBox.Show("error ");
        //resultat = zahl1 - zahl2;
        else if (comboBox.Text == "Geteilt")
          resultat = zahl1 / zahl2;
        else if (comboBox.Text == "Mal")
          resultat = zahl1 * zahl2;
        else if (comboBox.Text == "Modulo")
          resultat = zahl1 % zahl2;

        textBox3_ergebnis.Text = Convert.ToString(resultat);
      }
      catch(Exception err)
      {
        MessageBox.Show(err.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);




        //private void Form1_KeyPress(object sender, KeyPressEventArgs e){ } 



      }
    }
  }
}
