using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de A, B e C: ");
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            double triangulo = (A * C)/2;
            double circulo = (C * C) * 3.14159;
            double trapezio = ((A + B) / 2) * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3" , CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture) );
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3" , CultureInfo.InvariantCulture));





        }
    }

}


