using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>()
        {
            new Producto{ ID=1, Nombre="Laptop", Categoria="Computo", Precio=15000, Stock=10 },
            new Producto{ ID=2, Nombre="Mouse", Categoria="Accesorios", Precio=300, Stock=50 },
            new Producto{ ID=3, Nombre="Teclado", Categoria="Accesorios", Precio=700, Stock=40 },
            new Producto{ ID=4, Nombre="Monitor", Categoria="Computo", Precio=4000, Stock=15 },
            new Producto{ ID=5, Nombre="USB", Categoria="Almacenamiento", Precio=200, Stock=60 },
            new Producto{ ID=6, Nombre="Disco Duro", Categoria="Almacenamiento", Precio=2500, Stock=20 },
            new Producto{ ID=7, Nombre="Audifonos", Categoria="Audio", Precio=900, Stock=25 },
            new Producto{ ID=8, Nombre="Bocinas", Categoria="Audio", Precio=1200, Stock=18 },
            new Producto{ ID=9, Nombre="Tablet", Categoria="Computo", Precio=8000, Stock=12 },
            new Producto{ ID=10, Nombre="MicroSD", Categoria="Almacenamiento", Precio=350, Stock=45 }
        };

        Console.WriteLine("Todos los productos:\n");
        foreach (var item in productos)
        {
            Console.WriteLine($"{item.Nombre} - {item.Categoria} - {item.Precio} - Stock: {item.Stock}");
        }
        Console.WriteLine("\n\n\n\n");

        Console.WriteLine("Productos con precio mayor a 1000:\n");
        var productosCaros = from p in productos
                             where p.Precio > 1000
                             select p;
        foreach (var item in productosCaros)
        {
            Console.WriteLine($"{item.Nombre} - {item.Precio}");
        }
        Console.WriteLine("\n\n\n\n");

        Console.WriteLine("Productos ordenados por precio de mayor a menor:\n");
        var productosOrdenados = from p in productos
                                 orderby p.Precio descending
                                 select p;
        foreach (var item in productosOrdenados)
        {
            Console.WriteLine($"{item.Nombre} - {item.Precio}");

        }
        Console.WriteLine("\n\n\n\n");

        Console.WriteLine("Productos agrupados por categoria:\n");
        var productosAgrupados = from p in productos
                                 group p by p.Categoria into g
                                 select new { Categoria = g.Key, Productos = g };
        foreach (var grupo in productosAgrupados)
        {
            Console.WriteLine($"Categoria: {grupo.Categoria}");
            foreach (var item in grupo.Productos)
            {
                Console.WriteLine($"  {item.Nombre} - {item.Precio}");
            }
        }
        Console.WriteLine("\n\n\n\n");

        Console.WriteLine("Clacular el Promedio de Precio por Categoria:\n");
        var promedioPrecio = from p in productos
                             group p by p.Categoria into g
                             select new { Categoria = g.Key, PromedioPrecio = g.Average(p => p.Precio) };
        foreach (var item in promedioPrecio)
        {
            Console.WriteLine($"Categoria: {item.Categoria} - Promedio de Precio: {item.PromedioPrecio}");
        }
        Console.WriteLine("\n\n\n\n");

        Console.WriteLine("Mostrar lista simplificada de productos con solo Nombre y Precio:\n");
        var productosSimplificados = from p in productos
                                     select new { p.Nombre, p.Precio };
        foreach (var item in productosSimplificados)
        {
            Console.WriteLine($"{item.Nombre} - {item.Precio}");
        }
    }
}