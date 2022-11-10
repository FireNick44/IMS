using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace IPT_Konsolen_Beispiel
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hello ");
      Console.WriteLine(" C#-Konsole");

      Console.Write("Wie heisst du: ");

      String vorname = Console.ReadLine();
      Console.WriteLine("Hallo " + vorname);

      Console.Write("Wie alt bist du: ");

      int alter = Convert.ToInt32(Console.ReadLine());

      String MsgText = String.Format("Hallo {0}, du bist {1} jahre alt", vorname, alter);
      Console.WriteLine("Hallo {0}, du bist {1} Jahre alt", vorname, alter);

      Console.WriteLine(MsgText);
      MessageBox.Show(MsgText,"Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Stop,
        MessageBoxDefaultButton.Button1);


      Console.Write("Drücken Sie eine Taste");
      //Console.ReadLine(); //Endet mit Enter auf.
      Console.ReadKey(); //Endet mit einer Taste.


    }
  }
}
