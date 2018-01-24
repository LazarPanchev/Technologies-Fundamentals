namespace RemoveElementsAtOddPositions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveElementsAtOddPositions
    {
        public static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<string> result = new List<string>();

            for (int i = 0; i <=inputText.Count-1; i++)
            {
                if(i%2==1)
                {
                    result.Add(inputText[i]);
                }
            }

            Console.WriteLine(String.Join("",result));
                
        }
    }
}
