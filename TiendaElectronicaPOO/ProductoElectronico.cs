public class ProductoElectronico : Producto
{
    public int GarantiaMeses { get; private set; }

    public ProductoElectronico(string nombre, decimal precio, string categoria, int garantiaMeses)
        : base(nombre, precio, categoria)
    {
        GarantiaMeses = garantiaMeses;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Nombre}");
        Console.WriteLine($"Categoría: {Categoria}");
        Console.WriteLine($"Precio: ${Precio}");
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine("----------------------------");
    }
}
