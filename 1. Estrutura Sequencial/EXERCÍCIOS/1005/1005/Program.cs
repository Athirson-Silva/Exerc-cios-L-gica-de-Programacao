using System;
using System.Globalization;
namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (n1 * 3.5 + n2 * 7.5) / 11;
            Console.WriteLine("MEDIA = " + average.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
