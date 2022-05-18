using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyCash = double.Parse(Console.ReadLine());
            string mail = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double card = 0;

            if (mail == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        card = 42;
                        break;
                    case "Boxing":
                        card = 41;
                        break;
                    case "Yoga":
                        card = 45;
                        break;
                    case "Zumba":
                        card = 34;
                        break;
                    case "Dances":
                        card = 51;
                        break;
                    case "Pilates":
                        card = 39;
                        break;
                    

                    default:
                        break;
                }
            }
            else if (mail == "f")
            {
                switch (sport)
                {
                    case "Gym":
                        card = 35;
                        break;
                    case "Boxing":
                        card = 37;
                        break;
                    case "Yoga":
                        card = 42;
                        break;
                    case "Zumba":
                        card = 31;
                        break;
                    case "Dances":
                        card = 53;
                        break;
                    case "Pilates":
                        card = 37;
                        break;


                    default:
                        break;
                }
            }


            if (age <= 19)
            {
                card = card - card * 0.2;
            }



            if (moneyCash >= card)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(card-moneyCash):f2} more.");
            }

        }
    }
}
