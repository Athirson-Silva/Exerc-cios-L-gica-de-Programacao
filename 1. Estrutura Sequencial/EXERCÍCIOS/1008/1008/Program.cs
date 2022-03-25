using System;
using System.Globalization;

namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hours * hourValue;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
