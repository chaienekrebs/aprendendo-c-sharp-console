using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de Variáveis.");

        int idade = 30;
        int idadeAna = idade;
        Console.WriteLine(idadeAna);

        idade = 25;
        Console.WriteLine(idadeAna);

        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}