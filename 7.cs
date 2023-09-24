using System;
					
public class Program
{
	public static void Main()
	{
		int i = 0;
		int numPar = 0;
		int numImpar = 0;
		
		while (i<10) {
			Console.WriteLine("Escreva um número inteiro: ");
			int num = Int32.Parse(Console.ReadLine());
			
			if (num%2==1) {
				numImpar = numImpar + 1;
			} else {
				numPar = numPar + 1;
			}
			i++;
		}
		
		Console.WriteLine("Quantidade de números pares: " + numPar);
		Console.WriteLine("Quantidade de números ímpares: " + numImpar);
	}
}