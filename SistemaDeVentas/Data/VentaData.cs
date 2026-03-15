using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaDeVentas.Models;

namespace SistemaDeVentas.Data
{
    public class VentaData
    {
        private string conexion = "Server=127.0.0.1;Database=SistemaDeVentas;Uid=root;Pwd=;";

        public VentaData()
        {
            EnsureTableExists();
        }

        private void EnsureTableExists()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        CREATE TABLE IF NOT EXISTS Ventas (
                            VentaID INT AUTO_INCREMENT PRIMARY KEY,
                            ClienteID INT NOT NULL,
                            ProductoID INT NOT NULL,
                            Cantidad INT NOT NULL,
                            Total DECIMAL(10, 2) NOT NULL,
                            FechaVenta DATETIME DEFAULT CURRENT_TIMESTAMP,
                            FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
                            FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
                        )";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating sales table: " + ex.Message);
            }
        }

        public bool GuardarVenta(int clienteID, int productoID, int cantidad, decimal total)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO Ventas (ClienteID, ProductoID, Cantidad, Total, FechaVenta)
                        VALUES (@clienteID, @productoID, @cantidad, @total, @fecha)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteID", clienteID);
                        cmd.Parameters.AddWithValue("@productoID", productoID);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving sale: " + ex.Message);
            }
        }

        public List<Venta> ObtenerVentasPorCliente(int clienteID)
        {
            List<Venta> ventas = new List<Venta>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        SELECT VentaID, ClienteID, ProductoID, Cantidad, Total, FechaVenta 
                        FROM Ventas 
                        WHERE ClienteID = @clienteID
                        ORDER BY FechaVenta DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteID", clienteID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ventas.Add(new Venta
                                {
                                    VentaID = Convert.ToInt32(reader["VentaID"]),
                                    ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                    ProductoID = Convert.ToInt32(reader["ProductoID"]),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                    Total = Convert.ToDecimal(reader["Total"]),
                                    FechaVenta = Convert.ToDateTime(reader["FechaVenta"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching sales: " + ex.Message);
            }

            return ventas;
        }
    }
}
