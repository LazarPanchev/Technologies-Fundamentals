using System;
using System.Linq;
using System.Collections.Generic;

namespace FilterBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> ageDict = new Dictionary<string, int>();
            Dictionary<string, double> salaryDict = new Dictionary<string, double>();
            Dictionary<string, string> positionDict = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "filter base")
            {
                string[] command =input
                .Split(' ');
                int age = 0;
                double salary;

                if (int.TryParse(command[2], out age))
                {
                    ageDict.Add(command[0], age);
                }

                else if (double.TryParse(command[2], out salary))
                {
                    salaryDict.Add(command[0], salary);
                }

                else
                {
                    positionDict.Add(command[0], command[2]);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (KeyValuePair<string, int> pair in ageDict)
                {
                    Console.WriteLine("Name: {0}", pair.Key);
                    Console.WriteLine("Age: {0}", pair.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }

            else if (input == "Salary")
            {
                foreach (KeyValuePair<string, double> pair in salaryDict)
                {
                    Console.WriteLine("Name: {0}", pair.Key);
                    Console.WriteLine("Salary: {0:F2}", pair.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }

            else
            {
                foreach (KeyValuePair<string, string> pair in positionDict)
                {
                    Console.WriteLine("Name: {0}", pair.Key);
                    Console.WriteLine("Position: {0}", pair.Value);
                    Console.WriteLine(new string('=', 20));
                }

            }

        }


    }
}
