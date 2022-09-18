using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a longo prazo.");
        double fatorRendimento = 1.05;
        double investimento = 1000;
        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 5; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.01; 
        }

        Console.WriteLine("Após 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}