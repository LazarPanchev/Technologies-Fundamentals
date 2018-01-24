namespace Last3ConsecutiveStrings
{
    using System;
    using System.Linq;

    public class Last3ConsecutiveStrings
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int count = 1;
            for (int i = words.Length- 1; i > 0; i--)
            {
                if (words[i]== words[i-1])
                {
                    count++;
                        if(count==3)
                    {
                        Console.WriteLine("{0} {0} {0}", words[i]);
                        break;
                    }
                }

                else
                {
                    count = 1;
                }
            }

        }
    }
}
