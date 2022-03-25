using System;

namespace _1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = 1;
            do
            {
                fatorial *= N;
                N--;
            } while (N > 0);

            Console.WriteLine(fatorial);
        }
    }
}
