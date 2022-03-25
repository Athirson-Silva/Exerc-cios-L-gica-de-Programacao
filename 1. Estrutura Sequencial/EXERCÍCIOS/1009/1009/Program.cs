using System;
using System.Globalization;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double salarioFixo, totalDeVendas;

            Nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("TOTAL = R$ " + (salarioFixo + totalDeVendas * 0.15).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
