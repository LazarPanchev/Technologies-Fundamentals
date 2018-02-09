using System;
using System.Linq;
using System.Collections.Generic;


namespace AverageStudentsGrades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string studentName = input[0];
                double grade = double.Parse(input[1]);
                AddGrade(dictionary,studentName,grade);
            }

            PrintResult(dictionary);
        }

        private static void PrintResult(Dictionary<string, List<double>> dictionary)
        {
            foreach (KeyValuePair<string,List<double>> pair in dictionary)
            {
                string name = pair.Key;
                List<double> studentGrades = pair.Value;
                double average = studentGrades.Average();
                Console.Write("{0} -> ",name);
                foreach (var grade in studentGrades)
                {
                    Console.Write("{0:F2} ", grade);
                }

                Console.WriteLine("(avg: {0:F2})", average);
            }
        }

        private static void AddGrade(Dictionary<string, List<double>> dictionary, string studentName, double grade)
        {
            if(! dictionary.ContainsKey(studentName))
            {
                dictionary[studentName] = new List<double>();
            }

            dictionary[studentName].Add(grade);
        }
    }
}
