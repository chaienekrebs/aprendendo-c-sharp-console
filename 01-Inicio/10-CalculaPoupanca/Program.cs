using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança.");
        int mes = 1;
        double investimento = 1000;
        Console.WriteLine(investimento);
        //rendimento de 0.5%

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.05;
            Console.WriteLine("No mês: " + mes + " você tem " + investimento);
            mes++;
        }


        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}