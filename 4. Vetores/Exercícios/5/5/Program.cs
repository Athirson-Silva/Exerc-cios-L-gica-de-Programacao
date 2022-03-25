using System;
using System.Globalization;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            int pares = 0;
            double soma = 0;
            string[] s = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(s[i], CultureInfo.InvariantCulture);
            }

            foreach (int bananinha in vet)
            {
                if (bananinha % 2 == 0)
                {
                    soma += bananinha;
                    pares++;
                }
            }
            soma /= (double) pares;
            Console.WriteLine("A média é: " + soma.ToString(CultureInfo.InvariantCulture)); //Não formata a  quantidade de casas, mas troca a virgula pelo ponto
        }
    }
}
