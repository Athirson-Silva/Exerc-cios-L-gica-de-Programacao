using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int olderAge = 0, olderName = 0;
            int N = int.Parse(Console.ReadLine());
            int[] idade = new int[N];
            string[] nome = new string[N];


            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            for (int i = 0; i < N; i++)
            {
                if (idade[i] > olderAge)
                {
                    olderAge = idade[i];
                    olderName = i;
                }
            }

            Console.WriteLine("Pesoa mais velha: " + nome[olderName]);
        }
    }
}
