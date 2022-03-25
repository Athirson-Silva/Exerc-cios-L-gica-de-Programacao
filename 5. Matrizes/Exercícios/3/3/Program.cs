using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), maior = -1999;

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
                    if (mat[i, j] > maior)
                        maior = mat[i, j];
                }

                Console.WriteLine(maior);
                maior = 0;
            }

        }
    }
}
