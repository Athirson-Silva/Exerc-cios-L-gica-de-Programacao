using System;

namespace _1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, soma, cont;

            X = int.Parse(Console.ReadLine());

            while (X != 0) {

                soma = 0;
                cont = 0;

                if (!(X % 2 == 0))
                    X++;
                
                while (cont <5)
                {
                    soma += X;
                    X += 2;
                    cont++;
                }

                Console.WriteLine(soma); 
                
                X = int.Parse(Console.ReadLine());

            }
        }
    }
}
