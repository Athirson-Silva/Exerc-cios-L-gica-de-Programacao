using System;

namespace _1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h1, m1, h2, m2, t1, t2, duracao, horasTotal, minutosTotal;
            string[] vet = Console.ReadLine().Split(' ');
            h1 = int.Parse(vet[0]);
            m1 = int.Parse(vet[1]);
            h2 = int.Parse(vet[2]);
            m2 = int.Parse(vet[3]);

            t1 = h1 * 60 + m1;
            t2 = h2 * 60 + m2;

            if (t2 > t1)
                duracao = t2 - t1;
            else
                duracao = (24 * 60 - t1) + t2;   // caso o instante t1 seja maior que o t2, significa que a duração foi mais que um dia, então reduzimos o tempo de 1 dia do instante t1

            horasTotal = duracao / 60;
            minutosTotal = duracao % 60;
           

            Console.WriteLine("O JOGO DUROU " + horasTotal + " HORA(S) E " + minutosTotal + " MINUTO(S)");
        }
    }
}
