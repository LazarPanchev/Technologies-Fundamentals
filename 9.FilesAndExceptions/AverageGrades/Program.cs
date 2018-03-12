using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> GardesList { get; set; }
        public double AverageGrade
        {
            get
            {
                return GardesList.Average();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            List<Student> studentsList = new List<Student>();
            var input=File.ReadAllLines("input.txt");
            int nLines = int.Parse(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                string[] command = input[i].Split(' ');
                string name = command[0];
                double[] grades = command.Skip(1).Select(double.Parse).ToArray();
                Student student = new Student();
                student.Name = name;
                student.GardesList = new List<double>();
                student.GardesList.AddRange(grades);
                studentsList.Add(student);
            }

            foreach (Student stud in studentsList.Where(s=>s.AverageGrade>=5.00)
                .OrderBy(s=>s.Name)
                .ThenByDescending(s=>s.AverageGrade))
            {
                string result = $"{stud.Name} -> {stud.AverageGrade:F2}" + Environment.NewLine;
                File.AppendAllText("output.txt", result);
            }


        }
    }
}
