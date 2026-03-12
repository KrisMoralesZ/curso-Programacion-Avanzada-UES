using System;

public class Usuario
{
    private string nombre;
    private int edad;
    private string correo;

    public Usuario(string nombre, int edad, string correo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.correo = correo;

        Console.WriteLine("Usuario creado correctamente");
    }

    public Usuario()
    {
        nombre = "Desconocido";
        edad = 0;
        correo = "Sin correo";

        Console.WriteLine("Usuario creado con valores por defecto");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Información del usuario:");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Correo: " + correo);
    }

    ~Usuario()
    {
        Console.WriteLine("Usuario eliminado");
    }
}
