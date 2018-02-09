namespace Camel_s_Back
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<int> buildings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int camelBackSize = int.Parse(Console.ReadLine());
            int rounds = 0;
            bool IsStable = true;
            while (camelBackSize != buildings.Count)
            {
                IsStable = false;
                rounds++;
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
            }

            if (IsStable)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", buildings));

            }
            else
            {
                Console.WriteLine("{0} rounds", rounds);
                Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
            }
        }


    }
}
