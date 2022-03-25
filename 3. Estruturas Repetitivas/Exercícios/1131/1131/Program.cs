using System;

namespace _1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 1, cont = 0, golsInter, golsGremio, inter = 0, gremio = 0, empates = 0;

            while (option != 2)
            {
                string[] vet = Console.ReadLine().Split(' ');
                golsInter = int.Parse(vet[0]);
                golsGremio = int.Parse(vet[1]);

                if (golsInter > golsGremio)
                    inter++;
                else if (golsGremio > inter)
                    gremio++;
                else
                    empates++;

                cont++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                option = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:" + inter);
            Console.WriteLine("Gremio:" + gremio);
            Console.WriteLine("Empates:" + empates);

            if (inter > gremio)
                Console.WriteLine("Inter venceu mais");
            else
                Console.WriteLine("Gremio venceu mais");
        }
    }
}
