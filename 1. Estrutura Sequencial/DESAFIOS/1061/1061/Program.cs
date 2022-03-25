using System;

namespace _1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day1, hours1, minutes1, seconds1, day2, hours2, minutes2, seconds2, day3, hours3, minutes3, seconds3, inicio, fim, duracao, resto;

            string[] vet = Console.ReadLine().Split(' ');
            day1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            hours1 = int.Parse(vet[0]);
            minutes1 = int.Parse(vet[2]);
            seconds1 = int.Parse(vet[4]);

            vet = Console.ReadLine().Split(' ');
            day2 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            hours2 = int.Parse(vet[0]);
            minutes2 = int.Parse(vet[2]);
            seconds2 = int.Parse(vet[4]);

            inicio = (day1 - 1) * 24 * 60 * 60 + hours1 * 60 * 60 + minutes1 * 60 + seconds1;
            fim = (day2 - 1) * 24 * 60 * 60 + hours2 * 60 * 60 + minutes2 * 60 + seconds2;

            duracao = fim - inicio;

            day3 = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);

            hours3 = resto / (60 * 60);
            resto = resto % (60 * 60);

            minutes3 = resto / 60;
            seconds3 = resto % 60;

            Console.WriteLine(day3 + " dia(s)");
            Console.WriteLine(hours3 + " hora(s)");
            Console.WriteLine(minutes3 + " minuto(s)");
            Console.WriteLine(seconds3 + " segundo(s)");

        }
    }
}
