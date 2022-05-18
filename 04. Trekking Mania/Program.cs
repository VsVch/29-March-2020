using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {


            double numGroups = double.Parse(Console.ReadLine());
            double countMusala = 0;
            double countMonblank = 0;
            double countKalima = 0;
            double countK2 = 0;
            double countEverest = 0;
            double countSum = 0;

            for (int i = 0; i < numGroups; i++)
            {
                double numPeople = double.Parse(Console.ReadLine());
                countSum += numPeople;

                if (numPeople <= 5)
                {
                    countMusala += numPeople;
                }
                else if (numPeople > 5 && numPeople <= 12)
                {
                    countMonblank += numPeople;
                }
                else if (numPeople > 12 && numPeople <= 25)
                {
                    countKalima += numPeople;
                }
                else if (numPeople > 25 && numPeople <= 40)
                {
                    countK2 += numPeople;
                }
                else if (numPeople > 40)
                {
                    countEverest += numPeople;
                }


            }


            


            Console.WriteLine($"{countMusala / countSum * 100:f2}%");
            Console.WriteLine($"{countMonblank / countSum*100:f2}%");
            Console.WriteLine($"{countKalima / countSum*100:f2}%");
            Console.WriteLine($"{countK2 / countSum*100:f2}%");
            Console.WriteLine($"{countEverest / countSum*100:f2}%");



        }
    }
}
