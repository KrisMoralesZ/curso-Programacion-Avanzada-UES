using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>()
        {
            new Empleado { Nombre = "Carlos", Departamento = "IT", Salario = 15000 },
            new Empleado { Nombre = "Ana", Departamento = "Ventas", Salario = 12000 },
            new Empleado { Nombre = "Luis", Departamento = "IT", Salario = 18000 },
            new Empleado { Nombre = "Maria", Departamento = "Recursos Humanos", Salario = 14000 },
            new Empleado { Nombre = "Pedro", Departamento = "IT", Salario = 16000 }
        };

        Console.WriteLine("Lista de Empleados:\n");
        foreach (var emp in empleados)
        {
            Console.WriteLine($"Nombre: {emp.Nombre} | Departamento: {emp.Departamento} | Salario: {emp.Salario}");
        }
        
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        Console.WriteLine("\nEmpleados del departamento de IT ordenados por salario:\n");
        var empleadosIT = from emp in empleados
                          where emp.Departamento == "IT"
                          orderby emp.Salario descending
                          select emp;


        foreach (var emp in empleadosIT)
        {
            Console.WriteLine($"Nombre: {emp.Nombre} | Departamento: {emp.Departamento} | Salario: {emp.Salario}");
        }

        Console.ReadKey();
    }
}