using System;

namespace _1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, horasTotal;
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (B <= A)
                horasTotal = (B + 24) - A;
            else
                horasTotal = B - A;

            Console.WriteLine("O JOGO DUROU "+ horasTotal + " HORA(S)");
        }
    }
}
