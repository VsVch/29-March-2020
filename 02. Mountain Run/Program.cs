using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());


            double allTime = metres * timeSec;
            
            allTime = allTime + Math.Floor(metres/50)*30;
            

            if (allTime < record)
            {
                Console.WriteLine($"Yes! The new record is {allTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(allTime-record):f2} seconds slower.");
            }


        }
    }
}
