using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M404_B2_Array
{
  public partial class Form1 : Form
  {
    List<int> zahlenfeld = new List<int>();
    public Form1()
    {
      InitializeComponent();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
      int newValue = Convert.ToInt32(tbx_eingabe_a.Text);
      zahlenfeld.Add(newValue);
      Aktualisieren();
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
      int toDelete = Convert.ToInt32(tbx_eingabe_l.Text);
      while (zahlenfeld.Contains(toDelete))
      {
        zahlenfeld.Remove(toDelete);
      }
      Aktualisieren();
    }
    private void Aktualisieren()
    {
      listBox1.Items.Clear();
      int max = zahlenfeld.Max();
      int min = zahlenfeld.Min();
      double durchschnitt = zahlenfeld.Average();
      foreach (int v in zahlenfeld)
      {
        listBox1.Items.Add(v);
      }
      tbx_ausgabe_min.Text = Convert.ToString(min);
      tbx_ausgabe_max.Text = Convert.ToString(max);
      tbx_ausgabe_durch.Text = durchschnitt.ToString();
    }
  }
}
