using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {

            double eating = double.Parse(Console.ReadLine());
            eating = eating * 1000;
            string isAdopted = Console.ReadLine();
            double dayEat = 0;
            double sumEat = 0;

            while (isAdopted != "Adopted")
            {
                dayEat = double.Parse(isAdopted);
                sumEat += dayEat;


                isAdopted = Console.ReadLine();
            }


            if (eating >= sumEat)
            {
                Console.WriteLine($"Food is enough! Leftovers: {eating-sumEat} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sumEat - eating} grams more.");
            }


        }
    }
}
