

namespace ReverseCharacters
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            string result = string.Format("{0}{1}{2}", thirdLetter, secondLetter, firstLetter);
            Console.WriteLine(result);
        }
    }
}
