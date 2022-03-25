using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
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
                soma += mat[i, i];
            }
            Console.WriteLine(soma);
        }
    }
}
