using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {

            double fullCapacity = double.Parse(Console.ReadLine());
            double capacityBagadje = 0;
            int count = 0;
            double newOne = 0;

            while (capacityBagadje < fullCapacity)
            {
                string neBagadje = Console.ReadLine();
                
                if (neBagadje == "End")
                {
                    Console.WriteLine($"Congratulations! All suitcases are loaded!");
                    break;
                }
                
                newOne = double.Parse(neBagadje);
                capacityBagadje += newOne;
                if (capacityBagadje >=fullCapacity)
                {
                    Console.WriteLine($"No more space!");
                    break;
                }
                count++;
            }


            Console.WriteLine($"Statistic: {count} suitcases loaded.");
        }
    }
}
