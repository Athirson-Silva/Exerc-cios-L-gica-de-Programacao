using System;
using System.Globalization;

namespace _1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (X >= 0 && X <= 25)
                Console.WriteLine("Intervalo [0,25]");
            else if (X > 25 && X <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (X > 50 && X <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (X > 75 && X <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora de intervalo");

        }
    }
}
