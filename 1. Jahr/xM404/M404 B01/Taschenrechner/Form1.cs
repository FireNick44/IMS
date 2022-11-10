using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
  
  public partial class Taschenrechner : Form
  {
      double operand1 = 0.00;
    double operand2 = 0.00;
    string operation = "";
    bool isInputAfterResultOrOperation = false;

    public Taschenrechner()
    {
      InitializeComponent();
    }

    private void OnDigitClick(object sender, EventArgs e)
    {
      if (isInputAfterResultOrOperation)
      {
        tbx_ausgabe.Text = "";
        isInputAfterResultOrOperation = !isInputAfterResultOrOperation;
      }

      string s = ((Button)sender).Text;
      if (s == "." && tbx_ausgabe.Text.Length == 0)
        tbx_ausgabe.Text = "0.";
      else if (s != "." || tbx_ausgabe.Text.Contains(".") == false)
        tbx_ausgabe.Text += s;
    }
    private void OnOperation(object sender, EventArgs e)
    {
      operand1 = Convert.ToDouble(tbx_ausgabe.Text);
      operation = ((Button)sender).Text;
      isInputAfterResultOrOperation = true;
    }
    private void OnCalculate(object sender, EventArgs e)
    {
      operand2 = Convert.ToDouble(tbx_ausgabe.Text);
      double resultat = 0;
      if (operation == "+")
        resultat = operand1 + operand2;
      else if (operation == "-")
        resultat = operand1 - operand2;
      else if (operation == "*")
        resultat = operand1 * operand2;
      else if (operation == ":")
        resultat = operand1 / operand2;
      tbx_ausgabe.Text = Convert.ToString(resultat);
      operand1 = 0.00;
      operand2 = 0.00;
      operation = "";
      isInputAfterResultOrOperation = true;
    }
    private void OnClear(object sender, EventArgs e)
    {
      operand1 = 0.00;
      operand2 = 0.00;
      operation = "";
      tbx_ausgabe.Text = "";
    }
    
  }

  
  /*public partial class Taschenrechner : Form
  {

    string eingabe = " ";
    string rechnung1 = "";
    string rechnung2 = " ";
    double rechnung21 = 0;
    double rechnung11 = 0;
    string art = "";
    bool next = true;
    public Taschenrechner()
    {
      InitializeComponent();
    }



    private void Eingabe(object sender, EventArgs e)
    {
      do
      {
        eingabe = ((Button)sender).Text;


        if (eingabe == "+") art = eingabe;
        else if (eingabe == "-") art = eingabe;
        else next = false;

        if (eingabe == "="){

          rechnung11 = Convert.ToDouble(rechnung1);
        rechnung21 = Convert.ToDouble(rechnung2);


        //if (art == "+") tbx_ausgabe.Text = rechnung11 + rechnung21;
            
            }//rechnen
        else if (eingabe != "=") rechnung1 = eingabe;

        tbx_ausgabe.Text += rechnung1;
      } while (next == true);

      eingabe = ((Button)sender).Text;
      rechnung2 = eingabe;
      tbx_ausgabe.Text += rechnung1;
    }
  }
  */
}
