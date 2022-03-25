using System;
using System.Globalization;
namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resto, notas100, notas50, notas20, notas10, notas5, notas2, moedas100, moedas050, moedas025, moedas010, moedas005, moedas001;
            double valor;
            
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int)(valor * 100.0 + 0.5);
            //macete para pegar valores com duas casas decimais, multiplicamos pelo tanto de casa decimais (10²) e somamos 0.5 para uma questão de arredondamento e incerteza do double

            Console.WriteLine("NOTAS:");
            notas100 = resto / (100*100); //multiplicamos todos os valores por cem por proporção
            resto = resto % (100*100);
            Console.WriteLine(notas100 + " nota(s) de R$ 100.00");

            notas50 = resto / (50*100);
            resto = resto % (50*100);
            Console.WriteLine(notas50 + " nota(s) de R$ 50.00");

            notas20 = resto / (20*100);
            resto = resto % (20*100);
            Console.WriteLine(notas20 + " nota(s) de R$ 20.00");

            notas10 = resto / (10*100);
            resto = resto % (10*100);
            Console.WriteLine(notas10 + " nota(s) de R$ 10.00");

            notas5 = resto / (5*100);
            resto = resto % (5*100);
            Console.WriteLine(notas5 + " nota(s) de R$ 5.00");

            notas2 = resto / (2*100);
            resto = resto % (2*100);
            Console.WriteLine(notas2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            moedas100 = resto / 100;
            resto = resto % 100;
            Console.WriteLine(moedas100 + " moeda(s) de R$ 1.00");

            moedas050 = resto / 50;
            resto = resto % 50;
            Console.WriteLine(moedas050 + " moeda(s) de R$ 0.50");

            moedas025 = resto / 25;
            resto = resto % 25;
            Console.WriteLine(moedas025 + " moeda(s) de R$ 0.25");

            moedas010 = resto / 10;
            resto = resto % 10;
            Console.WriteLine(moedas010 + " moeda(s) de R$ 0.10");

            moedas005 = resto / 5;
            resto = resto % 5;
            Console.WriteLine(moedas005 + " moeda(s) de R$ 0.05");

            moedas001 = resto / 1;
            Console.WriteLine(moedas001 + " moeda(s) de R$ 0.01");
           
        }
    }
}
