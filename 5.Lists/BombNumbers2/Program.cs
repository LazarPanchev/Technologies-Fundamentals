namespace BombNumbers2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombArgs= Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]==bombArgs[0])
                {
                    for (int j = i-bombArgs[1]; j <=bombArgs[1] +i; j++)
                    {
                        if(j>=0 && j<=numbers.Count-1)
                        {
                            numbers[j] = 0;
                        }

                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
