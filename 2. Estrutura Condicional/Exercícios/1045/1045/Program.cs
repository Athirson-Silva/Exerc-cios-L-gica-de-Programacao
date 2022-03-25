using System;
using System.Globalization;

namespace _1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, X;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (!(A > B && A > C))
            {
                if (A <= B && A >= C)
                {
                    X = A;
                    A = B;
                    B = X;
                }
                else if (A <= C && A >= B)
                {
                    X = A;
                    A = C;
                    C = B;
                    B = X;
                }
                else if (B > C)
                {
                    X = C;
                    C = A;
                    A = B;
                    B = X;
                }
                else if (C > B)
                {
                    X = A;
                    A = C;
                    C = X;
                }
                else if (B == C)
                {
                    C = A;
                    A = B;
                }
               
            }
            else if (C > B)
            {
                X = B;
                B = C;
                C = X;
            }
            Console.WriteLine("A :" + A + " B : " + B + " C: " + C);

            if (A >= (B + C))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else
            {
                if (A * A == (B * B + C * C))
                    Console.WriteLine("TRIANGULO RETANGULO");
                else if (A * A > (B * B + C * C))
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                else if (A * A < (B * B + C * C))
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if (A == B && B == C && A == C)
                    Console.WriteLine("TRIANGULO EQUILATERO");
                else if (A == B || A == C || C == B)
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
