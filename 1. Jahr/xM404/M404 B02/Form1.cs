using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M404_B02
{
  public partial class Beispiel1 : Form
  {
    public Beispiel1()
    {
      InitializeComponent();
    }


    enum tag 
    {
     Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag
    }

    private void btnAusgeben_Click(object sender, EventArgs e)
    {
      tag d1 = tag.Montag;
      textBox1.Text = (Convert.ToInt32(d1)).ToString();




    }
  }
}
