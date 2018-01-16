using System;

class ResizableArray
{
    public static void Main()
    {
        int[] numbersArray = new int[4];
        string[] inputString = Console.ReadLine().Split();
        int currentIndex = 0;

        while (inputString[0] != "end")
        {
            string command = inputString[0];

            if (command == "push")
            {
                numbersArray[currentIndex] = int.Parse(inputString[1]);
                currentIndex++;
            }

            else if (command == "pop")
            {
                numbersArray[currentIndex] = 0;
                currentIndex--;
            }

            else if (command == "removeAt")
            {
                int newIndex = numbersArray[1];
                numbersArray=ShiftArray(numbersArray, currentIndex, newIndex);
                currentIndex--;
            }

            else if (command == "clear")
            {
                currentIndex = 0;
            }

            if (currentIndex >= numbersArray.Length)
            {

                numbersArray = CreateNewArray(numbersArray);
            }



            inputString = Console.ReadLine().Split();
        }

        PrintArray(numbersArray, currentIndex);
    }

    public static int[] CreateNewArray(int[] numbersArray)
    {
        int[] newArray = new int[numbersArray.Length * 2];
        for (int i = 0; i < numbersArray.Length; i++)
        {
            newArray[i] = numbersArray[i];
        }

        numbersArray = newArray;
        return numbersArray;
    }

    public static void PrintArray(int[] numbersArray, int currentIndex)
    {
        if (currentIndex == 0)
        {
            Console.WriteLine("empty array");
        }
        else
        {


            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[] ShiftArray(int[] numbersArray, int currentIndex, int newIndex)
    {
        for (int i = newIndex; i < currentIndex; i++)
        {
            numbersArray[i] = numbersArray[i + 1];
        }

        return numbersArray;
    }
}