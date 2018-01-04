namespace MultiplyEvenbyOdds
{
    using System;
    public class MultiplyEvenByOdds
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }

        public static string Reverse(string number)
        {
            string result = string.Empty;
            for (int i =number.Length; i>0; i--)
            {
                result += number[i];
            }
            return result;
        }
        
    }
}
