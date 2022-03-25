using System;
using System.Globalization;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            double media = 0;
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) //Quando há 2 vetores fica dificil usar o foreach pois temos dois vetores e na sintaxe aplicamos somente 1 (Talvez tenha solução)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            foreach (double X in vet) //foreach (Para cada) dá um aplido para vet[1], vet[2]... e faz uma repetição em cada elemento do vetor
            {
                media += X;
            }

            media /= N;
            Console.WriteLine("Média: "+ media.ToString("F3", CultureInfo.InvariantCulture));
            foreach (double X in vet)
            {
                if (X < media)
                    Console.WriteLine(X.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
