using System;
using System.Globalization;
namespace _1041
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eixoX, eixoY;
            string[] vet = Console.ReadLine().Split(' ');

            eixoX = double.Parse(vet[0], CultureInfo.InvariantCulture);
            eixoY = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (eixoX == 0 & eixoY == 0)
                Console.WriteLine("Origem");
            else if (eixoY == 0)
                Console.WriteLine("Eixo X");
            else if (eixoX == 0)
                Console.WriteLine("Eixo Y");
            else if (eixoX > 0 && eixoY > 0)
                Console.WriteLine("Q1");
            else if (eixoX < 0 && eixoY > 0)
                Console.WriteLine("Q2");
            else if (eixoX < 0 && eixoY < 0)
                Console.WriteLine("Q3");
            else
                Console.WriteLine("Q4");
        }
    }
}
