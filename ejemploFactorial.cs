/*
 Obtenci�n del factorial de un n�mero
*/
using System;
					
public class Program
{
	public static void Main()
	{
		// Variables a utilizar
		// num 	 -	n�mero a obtener faxtorial [int]
		// i	 -	contador [int]
		// result-	resultado (num!) [long] para almacenar n�meros grandes
		int num, i;
		long result;
		
		// Pedir que n�mero se desea calcular el factorial
		Console.WriteLine("Introduce un n�mero: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		// Cuando se va a realizar multiplicaciones sucesivas, se inicia 
		// una variable donde guardar el resultado (acumulador) a 1 (1 x cualquier n�mero, da el mismo n�mero)
		// Luego el contador ir� de 1 hasta el n�mero a calcular
		// y se acumulan las multiplicaciones
		for(i = 1, result = 1; i <= num; result *= i, i++);
		Console.WriteLine("El factorial de {0} es {1}", num, result);		
		
	}
}