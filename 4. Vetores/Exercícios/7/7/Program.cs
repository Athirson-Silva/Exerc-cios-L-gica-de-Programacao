using System;
using System.Globalization;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            double[] N1 = new double[N];
            double[] N2 = new double[N];
            

            for (int i = 0; i < N; i++)              // Lê a entrada de N nomes e notas, e armazena cada valor em sua respectiva memória
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                N1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                N2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("\n Alunos aprovados: \n");

            for (int i = 0; i < N; i++)
            {
                if ((N1[i] + N2[i]) / 2.0 >= 6.0 )
                    Console.WriteLine(nomes[i]);
            }
        }
    }
}
