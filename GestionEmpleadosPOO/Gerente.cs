using System;

public class Gerente : Empleado
{
	private decimal Bonificacion;

	public Gerente(string nombre, int edad, decimal salarioBase, decimal bonificacion) : base(nombre, edad, salarioBase)
	{
		Bonificacion = bonificacion;
	}

	public override decimal CalcularSalario()
	{
		return SalarioBase + Bonificacion;
    }

	public override void MostrarInformacion()
	{
		base.MostrarInformacion();
        Console.WriteLine($"Tipo: Gerente");
		Console.WriteLine($"Salario Base: {SalarioBase:C}");
        Console.WriteLine($"Bonificación: {Bonificacion:C}");
		Console.WriteLine($"Salario Total: {CalcularSalario():C}");
    }
}
