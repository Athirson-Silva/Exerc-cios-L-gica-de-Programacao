using System;
using System.Globalization;
namespace _1156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = 1, Y = 1, soma = 0;
            do
            {
                soma += Y / X;
                X *= 2;
                Y += 2;
            } while (Y <= 39);

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
