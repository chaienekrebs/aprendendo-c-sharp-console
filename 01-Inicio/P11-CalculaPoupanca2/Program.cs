using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança.");
        double investimento = 1000;
        Console.WriteLine(investimento);
        
        for(int mes =1; mes<=12; mes++)
        {
            investimento *= 1.05;
            Console.WriteLine("No mês: " + mes + " você tem " + investimento);
        }

        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}