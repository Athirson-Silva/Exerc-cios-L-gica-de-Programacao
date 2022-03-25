using System;
using System.Globalization;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] produtos = new string[N];
            double[] compras = new double[N];
            double[] vendas = new double[N];
            double totalCompras = 0.0, totalvendas = 0.0, totalLucros = 0.0;
            int lucros10 = 0, lucros10_20 = 0, lucros20 = 0;

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produtos[i] = s[0];
                compras[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                vendas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

                if ((vendas[i] - compras[i]) / compras[i] < 0.1)
                    lucros10++;
                else if ((vendas[i] - compras[i]) / compras[i] >= 0.1 && ((vendas[i] - compras[i]) / compras[i] <= 0.2))
                    lucros10_20++;
                else
                    lucros20++;

                totalCompras += compras[i];
                totalvendas += vendas[i];
                totalLucros += (vendas[i] - compras[i]);
            }

            Console.WriteLine("\nLucro abaixo de 10%: " + lucros10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucros10_20);
            Console.WriteLine("Lucro acima de 20%: " + lucros20);

            Console.WriteLine("\nValor total de compra: " + totalCompras.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalvendas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucros.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
