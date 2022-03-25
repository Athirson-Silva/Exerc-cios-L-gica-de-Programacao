using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), soma = 0;
            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(v[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    soma += mat[i, j];
                }

                Console.WriteLine(soma);
                soma = 0;
            }

        }
    }
}
