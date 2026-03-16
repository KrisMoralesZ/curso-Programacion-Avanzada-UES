using System;

namespace SistemaDeVentas.Models
{
    public class Venta
    {
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
