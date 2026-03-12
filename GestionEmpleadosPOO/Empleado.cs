using System;

public class Empleado
{
    protected string Nombre;
    protected int Edad;
    protected decimal SalarioBase;

    public Empleado(string nombre, int edad, decimal salarioBase)
    {
        Nombre = nombre;
        Edad = edad;
        SalarioBase = salarioBase;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
    }
}