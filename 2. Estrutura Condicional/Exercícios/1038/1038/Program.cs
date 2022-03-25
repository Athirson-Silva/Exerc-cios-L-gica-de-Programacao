using System;
using System.Globalization;
namespace _1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    total = (double) quantidade * 4.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 2:
                    total = (double)quantidade * 4.5;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 3:
                    total = (double)quantidade * 5.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 4:
                    total = (double)quantidade * 2.0;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 5:
                    total = (double)quantidade * 1.5;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            
        }
    }
}
