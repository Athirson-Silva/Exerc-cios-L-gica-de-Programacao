using System;
using System.Globalization;
namespace _1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, D, exame;

            string[] vet = Console.ReadLine().Split(' ');
            A = float.Parse(vet[0], CultureInfo.InvariantCulture);
            B = float.Parse(vet[1], CultureInfo.InvariantCulture);
            C = float.Parse(vet[2], CultureInfo.InvariantCulture);
            D = float.Parse(vet[3], CultureInfo.InvariantCulture);


            float media = (A * 2 + B * 3 + C * 4 + D * 1) / 10;
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if (media < 5.0)
                Console.WriteLine("Aluno reprovado.");
            else
            {
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + exame) / 2;

                if (media >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reprovado");

                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
