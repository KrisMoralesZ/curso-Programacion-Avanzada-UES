namespace SistemaDeVentas.Models
{
    internal class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
    }
}
