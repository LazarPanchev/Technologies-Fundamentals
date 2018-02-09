namespace ChangeList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commands = Console.ReadLine().Split(' ');

            while (commands[0] != "Odd" || commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int number = int.Parse(commands[1]);

                    while (numbers.Contains(number))
                    {
                        numbers.Remove(number);
                    }
                }

                else if(commands[0]=="Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);

                    numbers.Insert(position,element);

                }
  
                commands = Console.ReadLine().Split(' ');
            }

            PrintList(numbers, commands[0]);
        }

        private static void PrintList(List<int> numbers, string command)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if(command=="Odd")
                {
                    i++;
                }

                Console.Write(numbers[i]);
            }
        }
    }
}
