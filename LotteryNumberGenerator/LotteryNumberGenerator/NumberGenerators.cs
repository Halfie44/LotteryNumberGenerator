using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    public class NumberGenerators
    {
        private static readonly List<int> allLottoNumbers = Enumerable.Range(1, 49).ToList();
        private static Dictionary<int, ConsoleColor> chosenNumbersList = new Dictionary<int, ConsoleColor>();
        private static readonly Random rand = new();

        public static Dictionary<int, ConsoleColor> ChosenNumbers
        {
            get
            {
                chosenNumbersList = new Dictionary<int, ConsoleColor>();
                var selectNumbersList = allLottoNumbers.OrderBy(x => rand.Next()).Take(6).OrderBy(x => x).ToList();

                foreach (int number in selectNumbersList)
                {
                    if (number <= 9)
                        chosenNumbersList.Add(number, ConsoleColor.Gray);
                    else if (10 <= number && number <= 19)
                        chosenNumbersList.Add(number, ConsoleColor.Blue);
                    else if (20 <= number && number <= 29)
                        chosenNumbersList.Add(number, ConsoleColor.Magenta);
                    else if (30 <= number && number <= 39)
                        chosenNumbersList.Add(number, ConsoleColor.Green);
                    else
                        chosenNumbersList.Add(number, ConsoleColor.Yellow);
                }

                return chosenNumbersList;
            }
        }

        public static int BonusBall
        {
            get
            {
                if (chosenNumbersList.Count != 0)
                    return allLottoNumbers.Where(i => chosenNumbersList.Any(j => j.Key != i)).OrderBy(k => rand.Next()).ToList().FirstOrDefault();
                else
                    return 0;
            }
        }
    }
}
