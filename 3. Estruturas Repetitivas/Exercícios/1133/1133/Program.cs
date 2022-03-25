using System;

namespace _1133
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

            for (int i = y+1; i < x; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                    Console.WriteLine(i);
            }
        }
    }
}

