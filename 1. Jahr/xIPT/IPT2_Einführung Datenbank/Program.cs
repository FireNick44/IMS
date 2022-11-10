using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPT2_Einführung_Datenbank
{
  class Program
  {
    static void Main(string[] args)
    {
      OleDbConnection dbConnect = new OleDbConnection();
      dbConnect.ConnectionString = "Provider=MSOLEDBSQL;" +
                                   "Server=BMWP1;" +
                                   "Database=KUNDE;" +
                                   "Trusted_Connection=yes";

      //öffnet Datenbank
      try
      {
        //Datenbankverbindung herstellen
        dbConnect.Open();
        MessageBox.Show("Datenbank geöffnet");

        //Datenbank Kommando erstellen
        OleDbCommand DbCmd = new OleDbCommand();
        DbCmd.Connection = dbConnect;
        DbCmd.CommandText = "SELECT * from KUNDE";

        //Datenbank Kommando ausführen
        OleDbDataReader DbReader = DbCmd.ExecuteReader();

        //Ausgabe
        Console.WriteLine("Inhalt von Tabelle Kunde:");
        while (DbReader.Read())
        {
          Console.WriteLine("{0} {1} {2}", DbReader["Vorname"],
                                           DbReader["Nachname"],
                                           DbReader["Jahrgang"]);
        }



      } catch (Exception exp) {
        MessageBox.Show(exp.Message);
      } finally {
        dbConnect.Close();
      }



      Console.ReadLine();
    }
  }
}
