namespace CharRotation
{
    using System;
    using System.Linq;
    public class CharRotation
    {
        public static void Main()
        {
            char[] inputText = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {

                int currentCharNum = inputText[i];
                int result = 0;
                if (numbers[i] % 2 == 0)
                {
                    result = currentCharNum - numbers[i];
                }

                else
                {
                    result = currentCharNum + numbers[i];
                }

                inputText[i] = (char)result;


            }

            Console.WriteLine(String.Join("", inputText));
        }
    }
}
