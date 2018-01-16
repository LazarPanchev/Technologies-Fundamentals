namespace Phonebook
{
    using System;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            string[] phones = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string command = Console.ReadLine();
            int searchingIndex = 0;
            bool haveMatch = false;
            while(command!="done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if(command.Equals(names[i]))
                    {
                        searchingIndex = i;
                        haveMatch = true;
                    }

                    if(haveMatch)
                    {
                        Console.WriteLine("{0} -> {1}",names[searchingIndex], phones[searchingIndex]);
                        haveMatch = false;
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
