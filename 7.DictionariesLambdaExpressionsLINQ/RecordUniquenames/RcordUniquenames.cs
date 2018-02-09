using System;
using System.Linq;
using System.Collections.Generic;

namespace RecordUniquenames
{
    public class RcordUniqueNames
    {
        public static void Main(string[] args)
        {
            HashSet<string> hashSetNames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                hashSetNames.Add(name);
            }

            foreach (string name in hashSetNames)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
