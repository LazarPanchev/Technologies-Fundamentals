namespace Substring
{
    using System;

    public class Substring
    {
        /// <summary>
        /// //Debugging broken code-exercises
        /// </summary>
        public static void Main()
        {
            string text = Console.ReadLine();
            int numberCount = int.Parse(Console.ReadLine());

            char searchedLetter ='p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == searchedLetter)
                {
                    string substring = string.Empty;
                    hasMatch = true;

                    int endIndex = numberCount;
                    bool reachEndOfString = false;

                    if (i+endIndex > text.Length-1)
                    {
                        substring ="p";
                        for (int j =i+1; j <=text.Length-1; j++)
                        {
                            reachEndOfString = true;
                            substring += text[j];                           
                        }
                    }

                    if(reachEndOfString==true)
                    {
                        Console.WriteLine(substring);
                        break;
                    }

                    substring = text.Substring(i, endIndex+1);
                    Console.WriteLine(substring);
                    i += numberCount;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
