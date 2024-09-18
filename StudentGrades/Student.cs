using System;
using System.Collections.Generic;

namespace StudentGradesApp
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        
        public List<double> Grades { get; set; } = new List<double>();
        
        public static void AddGrade(Student student, double grade)
        {
            student.Grades.Add(grade);
        }
        
        public static void AddGrade(Student student, params double[] grades)
        {
            student.Grades.AddRange(grades);
        }
        
        public static double CalculateAverageGrade(Student student)
        {
            if (student.Grades.Count == 0)
                return 0;
            double sum = 0;
            foreach (double grade in student.Grades)
            {
                sum += grade;
            }
            return sum / student.Grades.Count; 
        }
    }
}