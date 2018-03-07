using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
namespace SnowBalls
{
    public class Program
    {
        public static void Main()
        {
            int numberBalls = int.Parse(Console.ReadLine());
            BigInteger highestSnowBallValue = 0;
            BigInteger bestSnow = 0;
            BigInteger bestTime = 0;
            BigInteger bestQuality = 0;
            for (uint i = 0; i < numberBalls; i++)
            {
                BigInteger snowBallSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowBallTime = BigInteger.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallValue =BigInteger.Pow(snowBallSnow / snowBallTime, snowBallQuality);
                if (snowBallSnow == 0 && snowBallTime == 0)
                {
                    snowBallValue = 0;
                }
                if (snowBallValue > highestSnowBallValue)
                {
                    highestSnowBallValue = snowBallValue;
                    bestSnow = snowBallSnow;
                    bestTime = snowBallTime;
                    bestQuality = snowBallQuality;
                }

            }
            if(numberBalls==0)
            {
                Console.WriteLine($"{0} : {0} = {0} ({0})");
            }
            else
            {
                  Console.WriteLine($"{bestSnow} : {bestTime} = {highestSnowBallValue} ({bestQuality})");
            }

        }
    }
}
