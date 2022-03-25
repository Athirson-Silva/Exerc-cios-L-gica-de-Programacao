using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                C[i] = B[i] + A[i];
                Console.WriteLine(C[i]);
            }

        }
    }
}
