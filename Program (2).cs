using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Verifica qual é o menor e o maior número
        int inicio = Math.Min(numero1, numero2);
        int fim = Math.Max(numero1, numero2);

        Console.WriteLine($"Números no intervalo entre {inicio} e {fim}:");
        for (int i = inicio; i <= fim; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine(); // Pula uma linha no final
    }
}



