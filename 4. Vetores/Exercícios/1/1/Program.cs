using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, maior = 1, posicaoMaior = 0;
            int[] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s[i]);
            }
          
            for (int i = 0; i < N; i++)
            {
                if (A[i] > maior)
                {
                    maior = A[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine("O maior é: " + maior);
            Console.WriteLine("A posição do maior é: " + posicaoMaior);
        }
    }
}
