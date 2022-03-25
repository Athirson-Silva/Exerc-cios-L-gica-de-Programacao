using System;

namespace _1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0, entrada = 0;
            
            while (entrada != 4)
            {
                entrada = int.Parse(Console.ReadLine());

                if (entrada == 1)
                    alcool++;
                else if (entrada == 2)
                   gasolina++;
                else if (entrada == 3)
                    diesel++;
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
