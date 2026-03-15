using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaDeVentas
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      string conexion = "Server=127.0.0.1;Database=SistemaDeVentas;Uid=root;Pwd=;";

      using (MySqlConnection conn = new MySqlConnection(conexion))
      {
        conn.Open();

      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());

    }
  }
}
