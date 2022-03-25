using System;
using System.Globalization;

namespace _1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, pi;
            pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("TRIANGULO: " +  (A * C / 2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (pi * C * C).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + ((A+B) * C/2.0).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (B * B).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
