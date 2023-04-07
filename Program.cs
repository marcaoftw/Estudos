using ExerciciosClasseAtributosMetodos;
using System;
using System.Globalization;

namespace ExerciciosClasseAtributosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Qual é a cotação do Dólar?");
            double cotacao =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares vai comprar, em reais?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(cotacao, quantia).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}




/*

{
    Aluno aln = new Aluno();

    Console.Write("Nome do aluno: ");
    aln.Name = Console.ReadLine();
    Console.WriteLine("Digite as 3 notas do aluno: ");
    aln.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aln.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aln.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("NOTA FINAL = " + aln.NotaFinal());

    if (aln.Aprovacao() == true)
    {
        Console.WriteLine("APROVADO!");
    }
    else
    {
        Console.WriteLine("REPROVADO!");
        Console.WriteLine("NOTA FALTANTE: " + aln.NotaFaltante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");
    }


}
*/
/*
{
    static void Main(string[] args)
    {
        Funcionario F = new Funcionario();

        Console.WriteLine("Nome: ");
        F.Name = Console.ReadLine();
        Console.WriteLine("Salário Bruto: ");
        F.SalaryB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Imposto: ");
        F.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Funcionário: " + F.Name + ", $ " + F.SalaryL());
        Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
        double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        F.BonusSalary(p);

        Console.WriteLine("Dados Atualizados: " + F.Name + ", $ " + F.SalaryL());


    }
}

*/


/*
{
    Retangulo R = new Retangulo();

    Console.WriteLine("Entre a largura e altura do retângulo, respectivamente:");
    R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("AREA = " + R.Area());
    Console.WriteLine("PERIMETRO = " + R.Perimetro());
    Console.WriteLine("DIAGONAL = " + R.Diagonal());

}
*/




