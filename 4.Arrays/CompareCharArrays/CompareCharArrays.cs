namespace CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int smallerArray = Math.Min(firstArray.Length, secondArray.Length);
            bool equalArrays = true;
            bool smallerFirst = false;
            for (int i = 0; i < smallerArray; i++)
            {             
                if(firstArray[i].Equals(secondArray))
                {
                    continue;
                }

                else
                {
                    equalArrays = false;

                    if (firstArray[i]<secondArray[i])
                    {
                        smallerFirst = true;
                        break;
                    }

                    else
                    {
                        break;
                    }
                    
                }
            }

            if(!equalArrays && firstArray.Length<secondArray.Length || smallerFirst)
            {
                Console.WriteLine(String.Join("",firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
        }
    }
}
