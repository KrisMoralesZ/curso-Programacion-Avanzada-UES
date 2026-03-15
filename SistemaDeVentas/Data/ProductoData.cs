using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaDeVentas.Models;

namespace SistemaDeVentas.Data
{
    public class ProductoData
    {
        private string conexion = "Server=127.0.0.1;Database=SistemaDeVentas;Uid=root;Pwd=;";

        public ProductoData()
        {
            EnsureTableExists();
            SeedProducts();
        }

        private void EnsureTableExists()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        CREATE TABLE IF NOT EXISTS Productos (
                            ProductoID INT AUTO_INCREMENT PRIMARY KEY,
                            Nombre VARCHAR(100) NOT NULL,
                            Descripcion VARCHAR(500),
                            Precio DECIMAL(10, 2) NOT NULL
                        )";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating products table: " + ex.Message);
            }
        }

        private void SeedProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // Check if products already exist
                    string checkQuery = "SELECT COUNT(*) FROM Productos";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            return; // Products already seeded
                        }
                    }

                    // Insert seed products
                    string seedQuery = @"
                        INSERT INTO Productos (Nombre, Descripcion, Precio)
                        VALUES 
                            ('Laptop Dell XPS', 'Laptop de alta performance con procesador Intel i7, 16GB RAM y SSD 512GB', 1299.99),
                            ('Mouse Logitech', 'Mouse inalambrico con precision de 4000 DPI, bateria de larga duracion', 49.99),
                            ('Teclado Mecanico', 'Teclado mecanico RGB con interruptores Cherry MX, muy resistente', 149.99),
                            ('Monitor LG 27in', 'Monitor IPS 4K de 27 pulgadas, ideal para diseno y edicion', 399.99),
                            ('Headphones Sony', 'Headphones con cancelacion de ruido activa y 30 horas de bateria', 249.99),
                            ('Webcam Logitech', 'Webcam 1080p con microfono integrado, perfecta para streaming', 79.99)";

                    using (MySqlCommand cmd = new MySqlCommand(seedQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error seeding products: " + ex.Message);
            }
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = "SELECT ProductoID, Nombre, Descripcion, Precio FROM Productos";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                productos.Add(new Producto
                                {
                                    PruductoID = Convert.ToInt32(reader["ProductoID"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Precio = Convert.ToDecimal(reader["Precio"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching products: " + ex.Message);
            }

            return productos;
        }
    }
}
