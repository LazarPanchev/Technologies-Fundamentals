namespace SumArrayElements
{
    using System;

    public class SumArrayElements
    {
        public static void Main()
        {
            int[] first = { 345, 780, 900};
            first[2] = 1000;

            string result = String.Join(" / ", first);
            Console.WriteLine(result);
            
        }
    }
}
