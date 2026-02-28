using System;

public class Vehiculo
{
    // Atributos privados (ocultamiento de datos)
    private string marca;
    private string modelo;
    private int anio;
    private decimal precio;

    // Propiedad Marca
    public string Marca
    {
        get { return marca; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                marca = value;
            else
                Console.WriteLine("La marca no puede estar vacía.");
        }
    }

    // Propiedad Modelo
    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                modelo = value;
            else
                Console.WriteLine("El modelo no puede estar vacío.");
        }
    }

    // Propiedad Año
    public int Anio
    {
        get { return anio; }
        set
        {
            if (value >= 1900 && value <= DateTime.Now.Year)
                anio = value;
            else
                Console.WriteLine("El año no es válido.");
        }
    }

    // Propiedad Precio
    public decimal Precio
    {
        get { return precio; }
        set
        {
            if (value > 0)
                precio = value;
            else
                Console.WriteLine("El precio debe ser mayor a 0.");
        }
    }

    // Método para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine("----- VEHÍCULO -----");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Año: {anio}");
        Console.WriteLine($"Precio: ${precio}");
        Console.WriteLine("--------------------\n");
    }
}