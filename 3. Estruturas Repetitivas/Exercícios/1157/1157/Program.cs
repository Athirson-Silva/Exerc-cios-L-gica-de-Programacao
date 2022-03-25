using System;

namespace _1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            X = int.Parse(Console.ReadLine());
            Y = 1;
            do
            {
                if (X % Y == 0)
                    Console.WriteLine(Y);
                Y++;
            } while (X >= Y);
        }
    }
}
