using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos.");

        char letra = 'C';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);
        string primeiraFrase = "Alura - Curso c# ";
        Console.WriteLine(primeiraFrase + 2022);

        string cursos = @"Cursos Disponíveis:
- C#
- JS
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle Enter para fechar");
        Console.Read();

    }
}