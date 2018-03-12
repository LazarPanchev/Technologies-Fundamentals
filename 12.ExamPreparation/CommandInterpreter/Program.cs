using System;
using System.Linq;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            string input = Console.ReadLine();

            string start;
            string count;
            while (input != "end")
            {
                string[] tokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                switch (tokens[0])
                {
                    case "reverse":
                        start = tokens[2];
                        count = tokens[4];
                        if (IsValidInput(numbers, start, count))
                        {
                            ReverseArray(numbers, start, count);
                        }

                        break;
                    case "sort":
                        start = tokens[2];
                        count = tokens[4];
                        if (IsValidInput(numbers, start, count))
                        {
                            SortArray(numbers, start, count);
                        }

                        break;
                    case "rollLeft":
                        count = tokens[1];
                        if (IsValidInput(numbers, int.Parse(count)))
                        {
                            RollLeft(numbers, count);
                        }

                        break;
                    case "rollRight":
                        count = tokens[1];
                        if (IsValidInput(numbers, int.Parse(count)))
                        {
                            RollRight(numbers, count);
                        }

                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();

            }
            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.WriteLine("]");
        }

        private static void RollRight(string[] numbers, string count)
        {
            for (int i = 0; i < int.Parse(count); i++)
            {
                string temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = temp;
            }
        }

        private static void RollLeft(string[] numbers, string count)
        {
            for (int i = 0; i < int.Parse(count); i++)
            {
                string temp = numbers[0];
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = temp;
            }
        }

        private static void SortArray(string[] numbers, string start, string count)
        {
            Array.Sort(numbers, int.Parse(start) + 1, int.Parse(count) + 1);
        }

        private static void ReverseArray(string[] numbers, string start, string count)//check
        {
            for (int i = 0; i < int.Parse(count) / 2; i++)
            {
                string temp = numbers[int.Parse(start) + i];
                numbers[int.Parse(start) + i] = numbers[int.Parse(start) + int.Parse(count) - 1 - i];
                numbers[int.Parse(start) + int.Parse(count) - 1 - i] = temp;
            }
            //Array.Reverse(numbers, start, count);
        }

        private static bool IsValidInput(string[] numbers, int count)
        {
            if (count >= 0) //possible to be count>0 check!)
            {

                return true;
            }

            Console.WriteLine("Invalid input parameters.");
            return false;
        }

        private static bool IsValidInput(int[] numbers, int start, int count)
        {
            if (start >= 0 && start <= numbers.Length - 1 && count >= 0 && start + count-1 <= numbers.Length) // check!
            {
                return true;
            }

            Console.WriteLine("Invalid input parameters.");
            return false;
        }
    }
}
