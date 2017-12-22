
namespace CatchTheThief
{
    using System;
    public class CatchTheThief
    {
        public static void Main()
        {
            string IdType = Console.ReadLine();     
            long maxValue = 0L;
            if(IdType=="sbyte")
            {
                maxValue = sbyte.MaxValue;
            }
            else if(IdType=="int")
            {
                maxValue = int.MaxValue;
            }
            else if(IdType=="long")
            {
                maxValue = long.MaxValue;
            }
            int n = int.Parse(Console.ReadLine());
            long idThief = long.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                long idNumber = long.Parse(Console.ReadLine());
                if(idNumber>idThief && idNumber<=maxValue)
                {
                    idThief = idNumber;
                }


            }
            Console.WriteLine(idThief);
        }
    }
}
