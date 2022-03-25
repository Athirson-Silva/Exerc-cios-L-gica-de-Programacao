using System;
using System.Globalization;
namespace _1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double leitura, notas;
            int cont = 0;
            notas = 0;
            while (cont <2)
            {
                leitura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ((leitura >= 0 && leitura <= 10))
                {
                    notas += leitura;
                    cont++;
                }
                else
                    Console.WriteLine("nota invalida");
            }
            Console.WriteLine("media = " + (notas / 2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
