using System.Collections.Generic;

public class Cliente
{
    public string Nombre { get; private set; }
    private List<Producto> carrito;

    public Cliente(string nombre)
    {
        Nombre = nombre;
        carrito = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        carrito.Add(producto);
        Console.WriteLine($"{producto.Nombre} agregado al carrito.");
    }

    public void MostrarCarrito()
    {
        Console.WriteLine($"\nCarrito de compras de {Nombre}:");
        decimal total = 0;

        foreach (var producto in carrito)
        {
            producto.MostrarInformacion();
            total += producto.Precio;
        }

        Console.WriteLine($"TOTAL A PAGAR: ${total}");
    }
}
