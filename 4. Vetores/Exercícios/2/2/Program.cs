using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pares=0;
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    pares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(pares);

        }
    }
}
