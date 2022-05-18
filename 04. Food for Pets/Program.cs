using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {


            int days = int.Parse(Console.ReadLine());
            double eating = double.Parse(Console.ReadLine());

            double gram = 0;

            double eatDog = 0;
            double eatCat = 0;
            
            

            for (int i = 1; i <= days; i++)
            {
                double dog = double.Parse(Console.ReadLine());
                double cat = double.Parse(Console.ReadLine());
               

                eatDog += dog;
                eatCat += cat;

                if (i %3 == 0)
                {
                    double currentBiscuits = (dog+cat) * 0.1;
                    gram += currentBiscuits;


                    


                }


            }

            Console.WriteLine($"Total eaten biscuits: {(Math.Round(gram))}gr.");

            double eatingCoging = 0;
            double eatingCating = 0;
            double sumEating = 0;


            sumEating = eatCat + eatDog;
            eatingCoging = eatDog / sumEating * 100;
            eatingCating = eatCat / sumEating * 100;
            sumEating = sumEating / eating*100;
            

            Console.WriteLine($"{sumEating:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatingCoging:f2}% eaten from the dog.");
            Console.WriteLine($"{eatingCating:f2}% eaten from the cat.");



        }
    }
}
