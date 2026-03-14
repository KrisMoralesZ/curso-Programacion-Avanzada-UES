using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
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
            string conexion = "Server=127.0.0.1;Database=GestionReportes;Uid=root;Pwd=;";


            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = "SELECT Nombre, Puesto, Salario FROM Empleados";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
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
                }

                MessageBox.Show("Conexion Establecida");

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
