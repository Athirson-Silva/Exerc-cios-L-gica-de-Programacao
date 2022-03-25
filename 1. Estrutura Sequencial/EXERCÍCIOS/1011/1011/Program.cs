using System;
using System.Globalization;

namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = 4.0 / 3 * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
