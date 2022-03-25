using System;
using System.Globalization;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int homens = 0, mulheres = 0;
            double[] alturas = new double[N];
            double media = 0, maior = 0, menor = 10;
            char[] sexo = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');                            //Leitura dos dados
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);

                if (alturas[i] > maior)         // comparação de maior e menor
                    maior = alturas[i];
                if (alturas[i] < menor)
                    menor = alturas[i];

                if (sexo[i] == 'F')         // somatória das média das alturas das mulheres para a média
                {
                    media += alturas[i];
                    mulheres++;
                }
                    

                if (sexo[i] == 'M')        // contagem de homens
                    homens++;
            }
            Console.WriteLine("\nMenor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + (media / mulheres).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Número de homens = " + homens);
        }
    }
}
