using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int manobra;
            int[,] pelotao = new int [M, N];

            for (int i = 0; i < M; i++) 
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    pelotao[i, j] = int.Parse(s[j]);
                }
            }

            int girarFila = (int.Parse(Console.ReadLine()) - 1);
            manobra = pelotao[girarFila, N - 1];

            for (int i = N-1; i > 0; i--)
                pelotao[girarFila, i] = pelotao[girarFila, i - 1];

            pelotao[girarFila, 0] = manobra;



            for (int i = 0; i < M; i++)
            {
                for (int j = 0;j < N; j++)
                    Console.Write(pelotao[i, j] + " ");
                Console.WriteLine();
            }
        } 
    }
}
