using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageGardes
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> GradesList { get; set; }
        public double AverageGrade
        {
            get
            {
                return GradesList.Average();
            }
        }
    }

    public class AverageGrades
    {
        public static void Main()
        {
            List<Student> studentsList = new List<Student>();
            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                List<double> grades = tokens.Skip(1).Select(double.Parse).ToList();

                Student student = new Student
                {
                    Name = name,
                    GradesList = grades,
                };
                studentsList.Add(student);
            }

            foreach (var student in studentsList.Where(x=>x.AverageGrade>=5.00).OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrade))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name,student.AverageGrade);
            }

        }
    }
}