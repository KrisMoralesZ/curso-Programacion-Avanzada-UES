using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== GESTIÓN DE USUARIOS ===\n");

        Usuario usuario1 = new Usuario("Carlos", 28, "carlos@email.com");
        usuario1.MostrarInformacion();

        Usuario usuario2 = new Usuario();
        usuario2.MostrarInformacion();

        Console.WriteLine("Presiona una tecla para eliminar el usuario 1...");
        Console.ReadKey();

        usuario1 = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }
}