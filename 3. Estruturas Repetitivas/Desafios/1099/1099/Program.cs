using System;

namespace _1099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, y, manobra, soma = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                soma = 0;
                string [] vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (!(x > y))
                {
                    manobra = x;
                    x = y;
                    y = manobra;
                }

                for (int j = y + 1; j < x; j++)
                {
                    if (j % 2 != 0)
                        soma += j;
                }
                Console.WriteLine(soma);
            }
        }
    }
}

