using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class LotteryFunctions
    {
        public static void RunLotteryGenerator()
        {
            Console.WriteLine("Lottery Numbers Generator");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Press any key to generate lottery numbers\n");
            Console.ReadKey(true);

            var chosenNumberDic = NumberGenerators.ChosenNumbers;

            foreach (var i in chosenNumberDic)
            {
                Thread.Sleep(1000);
                Console.BackgroundColor = i.Value;
                Console.ForegroundColor = ConsoleColor.Black;
                if (i.Key == chosenNumberDic.Last().Key)
                {
                    Console.Write(i.Key + "\n\n");
                }
                else
                {
                    Console.Write(i.Key + ",");
                }
                Console.ResetColor();
            }

            GetBonusBall();
            Restart();
        }

        public static void GetBonusBall()
        {
            Console.WriteLine("Please waiting providing bonus ball\n");

            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bonus ball is " + NumberGenerators.BonusBall);
            Console.ResetColor();
        }

        public static void Restart()
        {
            Console.WriteLine("Press r to restart\n\n");
            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine();

            if (input.KeyChar == 'r')
            {
                RunLotteryGenerator();
            }
        }
    }
}
