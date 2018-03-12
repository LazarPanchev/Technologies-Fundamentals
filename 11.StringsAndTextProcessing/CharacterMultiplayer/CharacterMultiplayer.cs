using System;
using System.Linq;
using System.Text;

namespace CharacterMultiplayer
{
    public class CharacterMultiplayer
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];
            int sum = 0;
            if(firstString.Length==secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[i] * secondString[i];
                }
            }
            else if(firstString.Length>secondString.Length)
            {
                sum = CalculateSum(secondString, firstString, sum);
            }
            else
            {
                sum = CalculateSum(firstString, secondString, sum);
            }

            Console.WriteLine(sum);
        }

        private static int CalculateSum(string shorttest, string longest, int sum)
        {
            for (int i = 0; i < shorttest.Length; i++)
            {
                sum += shorttest[i] * longest[i];
            }

            var remains = longest.Skip(shorttest.Length).ToArray();
            for (int i = 0; i < remains.Length; i++)
            {
                sum += remains[i];
            }

            return sum;
        }
    }
}
