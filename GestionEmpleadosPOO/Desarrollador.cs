using System;

public class Desarrollador : Empleado
{
	private int ProyectosCompletados;
	private decimal BonificacionPorProyecto;
	
	public Desarrollador(string nombre, int edad, decimal salarioBase, int proyectosCompletados, decimal bonificacionPorProyecto) : base(nombre, edad, salarioBase)
	{
		ProyectosCompletados = proyectosCompletados;
		BonificacionPorProyecto = bonificacionPorProyecto;
    }

	public override decimal CalcularSalario()
	{
		return SalarioBase + (ProyectosCompletados * BonificacionPorProyecto);
    }

	public override void MostrarInformacion()
		{
		base.MostrarInformacion();
		Console.WriteLine($"Tipo: Desarrollador");
		Console.WriteLine($"Salario Base: {SalarioBase:C}");
		Console.WriteLine($"Proyectos Completados: {ProyectosCompletados}");
		Console.WriteLine($"Bonificación por Proyecto: {BonificacionPorProyecto:C}");
		Console.WriteLine($"Salario Total: {CalcularSalario():C}");
    }
}
