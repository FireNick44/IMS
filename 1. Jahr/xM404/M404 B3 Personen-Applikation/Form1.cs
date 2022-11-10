using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M404_B3_Personen_Applikation
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void cmdNeuePerson_Click(object sender, EventArgs e)
    {

    }

    private void txtHaarfarbe_Click(object sender, EventArgs e)
    {
      ColorDialog cdlg = new ColorDialog();
      if (DialogResult.OK == cdlg.ShowDialog())
      txtHaarfarbe.BackColor = cdlg.Color;
    }




  }
}
