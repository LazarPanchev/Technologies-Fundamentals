namespace IntegerInsertion
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class IntegerInsertion
    {
        public static void Main()
        {
            List<int> numbersList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                command.ToCharArray();
                command.Reverse();
                int index = 0;
                foreach (char symbol in command)
                {
                    index = command[0] - '0';
                }

                int num = int.Parse(command);

                numbersList.Insert(index, num);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
