using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversoes e Outros Tipos.");

        double salario = 300.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);




        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}