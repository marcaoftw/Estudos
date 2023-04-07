using ExerciciosClasse;
using System;
using System.Security.Cryptography;

namespace ExerciciosClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            p1.Nome = "Carlos Silva";
            p2.Nome = "Ana Marques";
            p1.Salario = 6300;
            p2.Salario = 6700;

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.WriteLine("Nome: " + p1.Nome);
            Console.WriteLine("Idade: " + p1.Salario);
            Console.WriteLine("Dados da Segunda Pessoa:");
            Console.WriteLine("Nome: " + p2.Nome);
            Console.WriteLine("Idade: " + p2.Salario);
            Console.WriteLine("Salário médio: " + (p1.Salario + p2.Salario)/2);
        }
    }
}



/*
{
    Pessoa p1 = new Pessoa();
    Pessoa p2 = new Pessoa();
    p1.Nome = "Maria";
    p2.Nome = "João";
    p1.Idade = 17;
    p2.Idade = 16;

    Console.WriteLine("Dados da Primeira Pessoa:");
    Console.WriteLine("Nome: " + p1.Nome);
    Console.WriteLine("Idade: " + p1.Idade);
    Console.WriteLine("Dados da Segunda Pessoa:");
    Console.WriteLine("Nome: " + p2.Nome);
    Console.WriteLine("Idade: " + p2.Idade);
}
*/











