using System;
using System.Windows.Forms;
using SistemaDeVentas.Forms;

namespace SistemaDeVentas
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
