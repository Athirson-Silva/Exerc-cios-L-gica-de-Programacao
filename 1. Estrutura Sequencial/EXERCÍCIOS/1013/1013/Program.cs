using System;

namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            int maior = (A + B + Math.Abs(A - B)) / 2;

            maior = (maior + C + Math.Abs(maior - C)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
