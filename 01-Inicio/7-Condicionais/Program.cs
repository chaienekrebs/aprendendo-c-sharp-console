using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais.");

        int idadeJoao = 16;
        int quantidadePesssoas = 2;
        if (idadeJoao >= 18 || quantidadePesssoas > 1)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}