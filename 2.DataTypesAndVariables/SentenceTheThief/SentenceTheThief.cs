
namespace SentenceTheThief
{
    using System;
    public class SentenceTheThief
    {
        public static void Main()
        {
            string numeralType = Console.ReadLine();
            long maxValue = long.MaxValue;
            long minValue = long.MinValue;
            switch(numeralType)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    minValue = sbyte.MinValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    minValue = int.MinValue;
                    break;
            }
            int countOfIDs = int.Parse(Console.ReadLine());
            long idThief = long.MinValue;
            for (int i = 0; i < countOfIDs; i++)
            {
                long currentId = long.Parse(Console.ReadLine());
                if(currentId>idThief && currentId>=minValue && currentId<=maxValue)
                {
                    idThief = currentId;
                }
            }
            double sentence = 0.0;
            if(idThief>0)
            {
                sentence = Math.Ceiling(idThief / 127.0);
            }
            else
            {
                sentence = Math.Abs(Math.Ceiling(idThief / -128.0));
            }
            if(sentence==1)
            {
               Console.WriteLine($"Prisoner with id {idThief} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {idThief} is sentenced to {sentence} years");
            }
        }
    }
}
