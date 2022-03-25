using System;
using System.Globalization;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int linha, coluna;
            double soma = 0.0;
            double[,] mat = new double[N, N];

            for (int i = 0; i < N; i++)         // leitura de dados
            {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = double.Parse(v[j], CultureInfo.InvariantCulture);
                }
            }
            Console.WriteLine("\n\n");


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > 0.0)
                        soma += mat[i, j];
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS : " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("\n\n");

            Console.WriteLine("Escolha um índice de uma linha a ser lida: ");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine("LINHA ESCOLHIDA: ");
            for (int i =0; i < N; i++)
            {
                Console.Write(mat[linha, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("Escolha um índice de uma coluna a ser lida: ");
            coluna = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("DIAGONAL PRINCIPAL");
            for (int i = 0; i < N; i++)
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture)+ " ");
            Console.WriteLine("\n\n");

            for (int i = 0;i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0.0)
                        mat[i, j] = Math.Pow(mat[i, j], 2);
                }        
            }

            Console.WriteLine("MATRIZ ALTERADA");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
