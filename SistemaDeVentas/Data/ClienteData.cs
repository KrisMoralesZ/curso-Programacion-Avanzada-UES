using System;
using MySql.Data.MySqlClient;

namespace SistemaDeVentas.Data
{
    public class ClienteData
    {
        private string conexion = "Server=127.0.0.1;Database=SistemaDeVentas;Uid=root;Pwd=;";

        public ClienteData()
        {
            EnsureTableExists();
            SeedUsers();
        }

        private void EnsureTableExists()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        CREATE TABLE IF NOT EXISTS Clientes (
                            ClienteID INT AUTO_INCREMENT PRIMARY KEY,
                            Nombre VARCHAR(100) NOT NULL,
                            Correo VARCHAR(100) UNIQUE NOT NULL,
                            Domicilio VARCHAR(200),
                            Telefono VARCHAR(20),
                            Contraseña VARCHAR(255) NOT NULL
                        )";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating table: " + ex.Message);
            }
        }

        private void SeedUsers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // Check if users already exist
                    string checkQuery = "SELECT COUNT(*) FROM Clientes";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            return; // Users already seeded
                        }
                    }

                    // Insert seed users
                    string seedQuery = @"
                        INSERT INTO Clientes (Nombre, Correo, Contraseña, Domicilio, Telefono)
                        VALUES 
                            ('Admin User', 'admin@example.com', 'admin123', '123 Main St', '555-0001'),
                            ('Test User', 'test@example.com', 'test123', '456 Test Ave', '555-0002'),
                            ('Demo User', 'demo@example.com', 'demo123', '789 Demo Rd', '555-0003')";

                    using (MySqlCommand cmd = new MySqlCommand(seedQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error seeding users: " + ex.Message);
            }
        }

        public bool RegistrarCliente(string nombre, string correo, string contraseña, string domicilio, string telefono)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // Check if email already exists
                    string checkQuery = "SELECT COUNT(*) FROM Clientes WHERE Correo = @correo";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@correo", correo);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            throw new Exception("Email already registered.");
                        }
                    }

                    // Insert new client
                    string query = @"
                        INSERT INTO Clientes (Nombre, Correo, Contraseña, Domicilio, Telefono)
                        VALUES (@nombre, @correo, @contraseña, @domicilio, @telefono)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@domicilio", domicilio ?? "");
                        cmd.Parameters.AddWithValue("@telefono", telefono ?? "");

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Registration error: " + ex.Message);
            }
        }

        public bool ValidarCredenciales(string correo, string contraseña)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Clientes WHERE Correo = @correo AND Contraseña = @contraseña";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Authentication error: " + ex.Message);
            }
        }
    }
}
