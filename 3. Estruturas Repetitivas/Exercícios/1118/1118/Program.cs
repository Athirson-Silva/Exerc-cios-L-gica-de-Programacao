using System;
using System.Globalization;

namespace _1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double leitura, notas;
            int cont, loop = 1;
            while (loop == 1)
            {
                notas = 0;
                cont = 0;
                while (cont < 2)
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
                Console.WriteLine("media = " + (notas / 2.0).ToString("F2", CultureInfo.InvariantCulture));
                
                

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    loop = int.Parse(Console.ReadLine());                 
                } while (loop != 1 && loop != 2);


            }
        }
    }
}
