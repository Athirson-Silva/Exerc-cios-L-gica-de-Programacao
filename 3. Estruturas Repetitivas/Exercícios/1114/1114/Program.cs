using System;

namespace _1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("Senha Invalida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
