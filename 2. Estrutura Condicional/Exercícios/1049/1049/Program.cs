using System;

namespace _1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string q1 = Console.ReadLine();
            string q2 = Console.ReadLine();
            string q3 = Console.ReadLine();

            if (q1 == "vertebrado")
            { 
                if (q2 == "ave")
                { 
                    if (q3 == "carnivoro")
                        Console.WriteLine("aguia");
                    else if (q3 == "onivoro")
                        Console.WriteLine("pomba");
                }
                else if (q2 == "mamifero")
                {
                    if (q3 == "onivoro")
                        Console.WriteLine("homem");
                    else if (q3 == "herbivoro")
                        Console.WriteLine("vaca");
                }
            }
            else if (q1 == "invertebrado")
            {
                if (q2 == "inseto")
                {
                    if (q3 == "hematofago")
                        Console.WriteLine("pulga");
                    else if (q3 == "herbivoro")
                        Console.WriteLine("lagarta");
                }
                else if (q2 == "anelideo")
                {
                    if (q3 == "hematofago")
                        Console.WriteLine("sanguessuga");
                    else if (q3 == "onivoro")
                        Console.WriteLine("minhoca");
                }
            }
        }
    }
}
