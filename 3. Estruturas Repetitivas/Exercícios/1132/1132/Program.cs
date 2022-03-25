using System;

namespace _1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, manobra, soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (!(x > y))
            {
                manobra = x;
                x = y;
                y = manobra;
            }

            for (int i = y; i <= x; i++)
            {
                if (!(i % 13 == 0))
                    soma += i;   
            }

            Console.WriteLine(soma);
        }
    }
}

