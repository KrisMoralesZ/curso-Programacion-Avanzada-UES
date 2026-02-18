class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tienda Electronica");

        // Crear productos electrónicos
        ProductoElectronico laptop = new ProductoElectronico(
            "Laptop HP", 18000m, "Computación", 24);

        ProductoElectronico celular = new ProductoElectronico(
            "Smartphone Samsung", 12000m, "Telefonía", 12);

        ProductoElectronico audifonos = new ProductoElectronico(
            "Audífonos Bluetooth", 1500m, "Accesorios", 6);

        // Crear cliente
        Cliente cliente = new Cliente("Juan Pérez");

        // Agregar productos al carrito
        cliente.AgregarProducto(laptop);
        cliente.AgregarProducto(celular);
        cliente.AgregarProducto(audifonos);

        // Mostrar carrito
        cliente.MostrarCarrito();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
