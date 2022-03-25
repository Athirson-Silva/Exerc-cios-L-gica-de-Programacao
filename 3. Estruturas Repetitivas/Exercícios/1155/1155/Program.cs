using System;
using System.Globalization;
namespace _1155
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = 1, soma = 0;
            do
            {
                soma += 1 / X;
                X++;
            } while (X <= 100);

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
