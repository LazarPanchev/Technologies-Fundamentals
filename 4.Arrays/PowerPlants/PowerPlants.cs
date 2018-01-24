namespace PowerPlants
{
    using System;
    using System.Linq;

    public class PowerPlants
    {
        public static void Main()
        {
            int[] plantsPowerLevel = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int countDays = 0;
            int sum = CalculateSum(plantsPowerLevel);
            int countSeason = 0;

            while (sum != 0)
            {
                for (int i = 0; i < plantsPowerLevel.Length; i++)
                {
                    for (int day = 0; day < plantsPowerLevel.Length; day++)
                    {
                        if (i == day)
                        {
                            continue;
                        }

                        else
                        {
                            if (plantsPowerLevel[day] > 0)
                            {
                                plantsPowerLevel[day]--;
                            }
                        }
                    }

                    countDays++;
                    sum = CalculateSum(plantsPowerLevel);
                    if(sum==0)
                    {
                        break;
                    }

                    if (countDays % plantsPowerLevel.Length == 0)
                    {
                        countSeason++;
                        for (int j = 0; j < plantsPowerLevel.Length; j++)
                        {
                            if (plantsPowerLevel[j] != 0)
                            {
                                plantsPowerLevel[j]++;
                            }
                        }
                    }
                }

                sum = CalculateSum(plantsPowerLevel);
            }
            
            Console.WriteLine("survived {0} days ({1} seasons)", countDays, countSeason);
        }

        public static int CalculateSum(int[] plantsPowerLevel)
        {
            int sum = 0;
            for (int i = 0; i < plantsPowerLevel.Length; i++)
            {
                sum += plantsPowerLevel[i];
            }

            return sum;
        }
    }
}
