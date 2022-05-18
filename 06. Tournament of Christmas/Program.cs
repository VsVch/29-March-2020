using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string nameGames = string.Empty;
            string isWinLose = string.Empty;
            
            int winDays = 0;
            int loseDays = 0;
            double moneyDay = 0;
            double sumMoney = 0;
            double moneyWin = 20;

            for (int i = 0; i < days; i++)
            {

                int winGames = 0;
                int loseGames = 0;

                nameGames = Console.ReadLine();



                while (nameGames != "Finish")

                    
                {

                    isWinLose = Console.ReadLine();


                    if (isWinLose == "win")
                    {
                        winGames++;
                        moneyDay += 20;
                    }
                    else if (isWinLose == "lose")
                    {
                        loseGames++;
                    }

                   

                    nameGames = Console.ReadLine();
                }

                if (winGames > loseGames)
                {
                    winDays++;
                    moneyDay = moneyDay + moneyDay * 0.1;
                }
                else
                {
                    loseDays++;
                }
                sumMoney += moneyDay;
                moneyDay = 0;
            }

            if (winDays > loseDays)
            {
                sumMoney = sumMoney + sumMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {sumMoney:f2}");
            }
            else
            {
               
                Console.WriteLine($"You lost the tournament! Total raised money: {sumMoney:f2}");
            }

            
            


        }
    }
}
