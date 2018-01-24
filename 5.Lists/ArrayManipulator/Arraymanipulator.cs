namespace ArrayManipulator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ArrayManipulator
    {
        public static List<int> inputArray;

        public static void Main()
        {
            inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "print")
            {

                switch (command[0])
                {
                    case "add": //work
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        inputArray.Insert(index, element);
                        break;
                    case "addMany":
                        int indexOfRange = int.Parse(command[1]);
                        inputArray.InsertRange(indexOfRange, AddManyElements(command));
                        break;
                    case "contains": //work
                        int number = int.Parse(command[1]);
                        ElementsContains(number);
                        break;
                    case "remove":
                        int indexForRemove = int.Parse(command[1]);
                        inputArray.RemoveAt(indexForRemove);
                        break;
                    case "shift":
                        int numberRotations = int.Parse(command[1]);
                        ShiftList(numberRotations);
                        break;
                    case "sumPairs":
                        SumPairs();
                        break;


                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputArray));

        }

        private static void SumPairs()
        {
            List<int> result = new List<int>();
            bool oddArray = false;
            if (inputArray.Count % 2 == 1)
            {
                oddArray = true;
            }

            int index = 0;
            for (int i = 0; i < inputArray.Count / 2; i++)
            {
                int temporarySum = inputArray[index] + inputArray[index + 1];
                result.Add(temporarySum);
                index += 2;
            }

            if(oddArray==true)
            {
                result.Add(inputArray[inputArray.Count - 1]);
            }

            inputArray = result;
        }

        private static void ShiftList(int numberRotations)
        {
            int[] shifted = new int[numberRotations];
            for (int i = 0; i < numberRotations; i++)
            {
                shifted[i] = inputArray[i];
            }

            inputArray = inputArray.Skip(numberRotations).ToList();
            inputArray.AddRange(shifted);

        }

        private static void ElementsContains(int number)
        {
            if (inputArray.Contains(number))
            {
                Console.WriteLine("{0}", inputArray.IndexOf(number));
            }

            else
            {
                Console.WriteLine("-1");
            }
        }

        private static List<int> AddManyElements(string[] command)
        {
            List<int> nums = new List<int>();

            for (int i = 2; i < command.Length; i++)
            {
                nums.Add(int.Parse(command[i]));
            }

            return nums;
        }
    }
}
