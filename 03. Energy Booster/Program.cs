using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string set = Console.ReadLine();
            int numSet = int.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {

                case "Watermelon":
                    if (set == "small")
                    {
                        price = 2 * 56;
                    }
                    else if (set == "big")
                    {
                        price = 5 * 28.7;
                    }
                    break;
                case "Mango":
                    if (set == "small")
                    {
                        price = 2 * 36.66;
                    }
                    else if (set == "big")
                    {
                        price = 5 * 19.6;
                    }
                    break;
                case "Pineapple":
                    if (set == "small")
                    {
                        price = 2 * 42.1;
                    }
                    else if (set == "big")
                    {
                        price = 5 * 24.8;
                    }
                    break;
                case "Raspberry":
                    if (set == "small")
                    {
                        price = 2 * 20;
                    }
                    else if (set == "big")
                    {
                        price = 5 * 15.2;
                    }
                    break;
                default:
                    break;
            }


            price = price * numSet;

            if (price > 1000)
            {
                price = price / 2;
                Console.WriteLine($"{price:f2} lv.");
            }
            else if (price >= 400)
            {
                price = price * .85;
                Console.WriteLine($"{price:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{price:f2} lv.");
            }



        }
    }
}
