    int numero, multiplo, resultado;

    Console.WriteLine("Digite um número:............");
    numero = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Avaliar se é múltiplo:.......");
    multiplo = int.Parse(Console.ReadLine()!);
    
    resultado = numero / multiplo;

    if (numero % multiplo == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{numero} é multiplo por {multiplo}");
    }
    else 
    {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{numero} não é multiplo por {multiplo}");
    }