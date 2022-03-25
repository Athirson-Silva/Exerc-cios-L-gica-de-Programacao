using System;
using System.Globalization;


namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            double gas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consume = km/gas;

            Console.WriteLine(consume.ToString("F3", CultureInfo.InvariantCulture) + " km/l");


        }
    }
}
