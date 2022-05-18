using System;

namespace _02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int numWalk = int.Parse(Console.ReadLine());
            int kalorii = int.Parse(Console.ReadLine());

            double sumMin = min * numWalk;
            double sumKal = sumMin * 5;
            double halfKal = kalorii / 2;

            if (sumKal >= halfKal)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {sumKal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {sumKal}.");
            }










        }
    }
}
