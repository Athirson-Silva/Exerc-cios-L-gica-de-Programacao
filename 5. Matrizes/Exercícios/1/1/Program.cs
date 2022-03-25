using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int Linhas = int.Parse(s[0]);
            int Colunas = int.Parse(s[1]);

            int [,] mat = new int[Linhas, Colunas];

            for (int i = 0; i < Linhas; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < Colunas; j++)
                {
                    mat[i, j] = int.Parse(v[j]);
                }
            }

            Console.WriteLine("\nValores negativos: ");

            for (int i = 0; i < Linhas; i++)
            {
                for (int j = 0; j < Colunas; j++)
                {
                    if (mat[i, j] < 0)
                        Console.WriteLine(mat[i, j]);       
                }
            }

        }
    }
}
