using System;
using System.Globalization;

namespace _1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.WriteLine("MEDIA = " + average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
