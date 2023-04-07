using System;
using System.Globalization;

namespace ExerciciosClasseAtributosMetodos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6;
        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = (cotacao * quantia) * 1.06;
            return total;

        }


    }
}

/*
{
        public string Name;
public double N1;
public double N2;
public double N3;


public double NotaFinal()
{
    return N1 + N2 + N3;
}

public bool Aprovacao()
{
    if (NotaFinal() >= 60)
        return true;
    else
        return false;


}
public double NotaFaltante()
{
    return 60 - NotaFinal();
}


    }



*/

/*
 {
        public string Name;
        public double SalaryB;
        public double Taxes;

        public double SalaryL()
        {
            return SalaryB - Taxes;
        }
        public void BonusSalary(double percentual)
        {
            SalaryB += SalaryB * (percentual/100);
        }
       
     


    }

*/



/*
{
        public double Largura;

public double Altura;

public double Area()
{
    return Largura * Altura;

}

public double Perimetro()
{
    return 2 * Largura + 2 * Altura;

}

public double Diagonal()
{
    return Math.Sqrt(Altura * Altura + Largura * Largura);

}

       
     


    }
*/