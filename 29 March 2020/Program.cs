using System;

namespace _29_March_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            int countGames = int.Parse(Console.ReadLine());

            int daysWin = 0;
            int daysLose = 0;

           


            double allProfit = 0;


            for (int i = 0; i < countGames; i++)
            {

                int win = 0;
                int lose = 0;
                double profit = 0;


                while (true)
                {

                    string sport = Console.ReadLine();

                    if (sport == "Finish")
                    {
                        break;
                    }

                    string isWinLose = Console.ReadLine();


                
                
                        if (isWinLose == "win")
                        {
                            win++;
                            profit += 20;
                        }
                        else
                        {
                            lose++;
                        }
                    }
                
                
                

                if (win>lose)
                {
                    daysWin++;
                    profit = profit + 0.1 * profit;
                }
                else
                {
                    daysLose++;
                }
                allProfit += profit;

            }

            if (daysWin > daysLose)
            {
                allProfit = allProfit + allProfit * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {allProfit:f2}");
            }
            else
            {
                
                Console.WriteLine($"You lost the tournament! Total raised money: {allProfit:f2}");
            }


        }
    }
}
