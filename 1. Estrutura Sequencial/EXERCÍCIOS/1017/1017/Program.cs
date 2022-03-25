using System;
using System.Globalization;
namespace _1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int velocity = int.Parse(Console.ReadLine());

            int km = time * velocity;

            double gasConsume = (double) km / 12;

            Console.WriteLine(gasConsume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
