using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais e Boolean.");

        int idadeJoao = 16;
        int quantidadePesssoas = 2;
        bool acompanhado = quantidadePesssoas > 1;
        if (idadeJoao >= 18 || acompanhado)
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