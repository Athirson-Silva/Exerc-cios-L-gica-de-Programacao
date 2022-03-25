using System;
using System.Globalization;

namespace _1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioNovo, reajuste;
            int porcentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
                porcentual = 15;
            else if (salario <= 800.00)
                porcentual = 12;
            else if (salario <= 1200.00)
                porcentual = 10;
            else if (salario <= 2000.00)
                porcentual = 7;
            else
                porcentual = 4;

            reajuste = ((double) porcentual) * salario / 100;
            salarioNovo = salario + reajuste;

            Console.WriteLine("Novo salario: " + salarioNovo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + porcentual + " %");
        }
    }
}
