using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GESTIÓN DE VEHÍCULOS ===\n");

        // Crear primer vehículo
        Vehiculo vehiculo1 = new Vehiculo();
        vehiculo1.Marca = "Toyota";
        vehiculo1.Modelo = "Corolla";
        vehiculo1.Anio = 2020;
        vehiculo1.Precio = 250000;

        // Crear segundo vehículo
        Vehiculo vehiculo2 = new Vehiculo();
        vehiculo2.Marca = "Ford";
        vehiculo2.Modelo = "Mustang";
        vehiculo2.Anio = 2022;
        vehiculo2.Precio = 550000;

        // Mostrar información
        vehiculo1.MostrarInformacion();
        vehiculo2.MostrarInformacion();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}