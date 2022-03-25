using System;

namespace _1144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saida = 1, X;
            X = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine( saida + " " + (Math.Pow(saida, 2)) + " " + (Math.Pow(saida, 3)));
                Console.WriteLine(saida + " " + (Math.Pow(saida, 2) + 1) + " " + (Math.Pow(saida, 3) + 1));
                saida++;
            } while (saida <= X);
        }
    }
}
