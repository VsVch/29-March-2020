using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {

            double numBitcoins = double.Parse(Console.ReadLine());
            double numChainaYoana = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());


            double sum = numBitcoins * 1168 + numChainaYoana * 0.15 * 1.76;
            sum = sum / 1.95;
            sum = sum - sum * comision / 100;




            Console.WriteLine($"{sum:f2}");




        }
    }
}
