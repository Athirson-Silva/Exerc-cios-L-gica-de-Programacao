using System;
using System.Globalization;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] prod1 = Console.ReadLine().Split(' ');

            int cod1 = int.Parse(prod1[0]);
            int amount1 = int.Parse(prod1[1]);
            double value1 = double.Parse(prod1[2], CultureInfo.InvariantCulture);

            string[] prod2 = Console.ReadLine().Split(' ');

            int cod2 = int.Parse(prod2[0]);
            int amount2 = int.Parse(prod2[1]);
            double value2 = double.Parse(prod2[2], CultureInfo.InvariantCulture);

            double total = amount1 * value1 + amount2 * value2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
