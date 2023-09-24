using System;

class Program
{
    static void Main()
    {
        string nomeUsuario, senha;

        do
        {
            Console.Write("Digite um nome de usuário: ");
            nomeUsuario = Console.ReadLine();

            Console.Write("Digite uma senha: ");
            senha = Console.ReadLine();

            if (nomeUsuario == senha)
            {
                Console.WriteLine("A senha não pode ser igual ao nome de usuário. Tente novamente.");
            }
            else
            {
                Console.WriteLine("Cadastro realizado com sucesso!");
                break;
            }

        } while (true);
    }
}