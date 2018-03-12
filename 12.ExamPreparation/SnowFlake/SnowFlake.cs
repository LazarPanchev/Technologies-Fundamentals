using System;
using System.Text.RegularExpressions;

namespace _03_05._01._18_SnowFlake
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = 5;
            string surfacepattern = @"^([^A-Za-z0-9]+)$";
            string mantlePattern = @"^[0-9_]+$";
            string middleCorePattern = @"^([^A-Za-z0-9]+)[0-9_]+(?<core>[A-Za-z]+)[0-9_]+([^A-Za-z0-9]+)$";
            bool firstSurface = false;
            bool firstManthle = false;
            bool middlePart = false;
            bool secondMantle = false;
            bool secondSurface = false;
            int countCore = 0;
            for (int i = 0; i < nLines; i++)
            {
                string input = Console.ReadLine();
                Match surface = Regex.Match(input, surfacepattern);
                if(i==0 && surface.Success)
                {
                    firstSurface = true;
                }

                Match mantle = Regex.Match(input, mantlePattern);
                if(i==1 && mantle.Success)
                {
                    firstManthle = true;
                }

                Match middle = Regex.Match(input, middleCorePattern);
                if(i==2 && middle.Success)
                {
                    middlePart = true;
                    countCore = middle.Groups["core"].Length;
                }

                Match mantle2 = Regex.Match(input, mantlePattern);
                if (i == 3 && mantle2.Success)
                {
                    secondMantle = true;
                }

                Match surface2 = Regex.Match(input, surfacepattern);
                if (i == 4 && surface2.Success)
                {
                    secondSurface = true;
                }
            }

            if(firstSurface&& firstManthle && middlePart && secondMantle && secondSurface)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(countCore);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            
        }
    }
}