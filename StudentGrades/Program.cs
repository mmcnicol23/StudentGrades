using StudentGradesApp;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        
        Student mariah = new Student { Name = "Mariah McNicol", ID = 100 };
        Student shane = new Student { Name = "Shane McNicol", ID = 101 };
        Student kayla = new Student { Name = "Kayla Buchanan", ID = 102 };
        Student justin = new Student { Name = "Justin Brown", ID = 103 };
        
        students.Add(mariah);
        students.Add(shane);
        students.Add(kayla);
        students.Add(justin);
        
        Student.AddGrade(mariah, 94.3);
        Student.AddGrade(mariah, 90.0, 78.9, 95.4);

        Student.AddGrade(shane, 88.0);
        Student.AddGrade(shane, 91.2, 85.5);

        Student.AddGrade(kayla, 75.5);
        Student.AddGrade(kayla, 80.0, 70.2);

        Student.AddGrade(justin, 98.0);
        Student.AddGrade(justin, 96.4, 88.8);
        
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            Console.Write("Grades: ");
            foreach (var grade in student.Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine($"\nAverage Grade: {Student.CalculateAverageGrade(student)}");
            Console.WriteLine("--------------------------");
        }
    }
}