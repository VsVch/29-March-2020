using System;

namespace _01._Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            double zala = double.Parse(Console.ReadLine());
            double torta = zala * 0.2;
            double drink = torta * .55;
            double anime = zala / 3;
            double sum = zala + torta + drink + anime;
            Console.WriteLine($"{sum}");





        }
    }
}
