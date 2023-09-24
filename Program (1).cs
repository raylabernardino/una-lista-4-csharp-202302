static bool ValidarNome(string nome)
    {
        return nome.Length > 3;
    }

    static bool ValidarIdade(int idade)
    {
        return idade >= 0 && idade <= 150;
    }

    static bool ValidarSalario(decimal salario)
    {
        return salario > 0;
    }

    static bool ValidarSexo(char sexo)
    {
        return sexo == 'f' || sexo == 'm';
    }

    static bool ValidarEstadoCivil(char estadoCivil)
    {
        return estadoCivil == 's' || estadoCivil == 'c' || estadoCivil == 'v' || estadoCivil == 'd';
    }

    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        while (!ValidarNome(nome))
        {
            Console.WriteLine("Nome inválido. Deve conter mais de 3 caracteres.");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
        }

        Console.Write("Digite sua idade: ");
        int idade;
        while (!int.TryParse(Console.ReadLine(), out idade) || !ValidarIdade(idade))
        {
            Console.WriteLine("Idade inválida. Deve estar entre 0 e 150.");
            Console.Write("Digite sua idade: ");
        }

        Console.Write("Digite seu salário: ");
        decimal salario;
        while (!decimal.TryParse(Console.ReadLine(), out salario) || !ValidarSalario(salario))
        {
            Console.WriteLine("Salário inválido. Deve ser maior que zero.");
            Console.Write("Digite seu salário: ");
        }

        Console.Write("Digite seu sexo (f/m): ");
        char sexo;
        while (!char.TryParse(Console.ReadLine(), out sexo) || !ValidarSexo(sexo))
        {
            Console.WriteLine("Sexo inválido. Deve ser 'f' ou 'm'.");
            Console.Write("Digite seu sexo (f/m): ");
        }

        Console.Write("Digite seu estado civil (s/c/v/d): ");
        char estadoCivil;
        while (!char.TryParse(Console.ReadLine(), out estadoCivil) || !ValidarEstadoCivil(estadoCivil))
        {
            Console.WriteLine("Estado civil inválido. Deve ser 's', 'c', 'v' ou 'd'.");
            Console.Write("Digite seu estado civil (s/c/v/d): ");
        }

        Console.WriteLine("Informações válidas:");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Estado Civil: " + estadoCivil);
    }


