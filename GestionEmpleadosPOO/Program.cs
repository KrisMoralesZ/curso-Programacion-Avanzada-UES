class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GESTION DE EMPLEADOS ===\n");

        Empleado gerente = new Gerente("Alice", 45, 50000, 10000m);
        Empleado desarrollador = new Desarrollador("Bob", 30, 40000, 5, 2000m);

        Empleado[] empleados = new Empleado[] { gerente, desarrollador };

        foreach (Empleado empleado in empleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine();
        }

        Console.WriteLine("Presiona cualquier tecla para salir");
        Console.ReadKey();
    }
}