using System;
					
public class Program
{
	public static void Main()
	{
		//Faça um programa que leia 5 números e informe a soma e a média dos números.
		
		double resposta, resposta1;
		Console.WriteLine("Digite um numero");
		double num1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite um numero");
		double num2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite um numero");
		double num3 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite um numero");
		double num4 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite um numero");
		double num5 = Convert.ToDouble(Console.ReadLine());
		resposta = (num1 + num2 + num3 + num4 + num5) / 5;
		resposta1 = num1 + num2 + num3 + num4 + num5;
		Console.WriteLine(resposta);
		Console.WriteLine(resposta1);
		Console.ReadLine();
		
	}
}