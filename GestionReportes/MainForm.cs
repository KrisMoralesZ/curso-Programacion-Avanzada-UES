using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReportes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDescargarReporte_Click(object sender, EventArgs e)
        {
            string conexion = "Data Source=.;Initial Catalog=GestionReportes;Integrated Security=True";

            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    string query = "SELECT Nombre, Puesto, Salario FROM Empleados";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        empleados.Add(new Empleado
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Puesto = reader["Puesto"].ToString(),
                            Salario = Convert.ToDecimal(reader["Salario"])
                        });
                    }
                }

                var empleadosOrdenados = empleados
                                        .OrderBy(emp => emp.Nombre)
                                        .ToList();

                StringBuilder contenido = new StringBuilder();

                contenido.AppendLine("REPORTE DE USUARIOS");
                contenido.AppendLine("----------------------------");
                contenido.AppendLine("Nombre | Puesto | Salario");
                contenido.AppendLine("----------------------------");

                foreach (var emp in empleadosOrdenados)
                {
                    contenido.AppendLine($"{emp.Nombre} | {emp.Puesto} | {emp.Salario}");
                }

                string ruta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads",
                    "ReporteUsuarios.txt"
                );

                File.WriteAllText(ruta, contenido.ToString());

                MessageBox.Show("Reporte generado correctamente.");

                this.Close();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
