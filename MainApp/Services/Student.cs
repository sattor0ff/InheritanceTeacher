namespace MainApp.Services;

public class Student : Person
{
    private int _numCourses = 0;
    private List<string> courses;
    private List<int> grades;

    
    public Student(string name, string address) : base(name, address)
    {
        _name = name;
        _address = address;

        courses = new List<string>();
        grades = new List<int>();
    }
    public void AddCourseGrade(string course, int grade)
    {
        courses.Add(course);
        grades.Add(grade);
    }
    public void PrintGrades()
    {
        System.Console.Write("Grades: ");
        foreach (var element in grades)
        {
            System.Console.Write($"{element} ");
        }
        System.Console.WriteLine();
    }
    public void PrintCourse()
    {
        System.Console.Write("Course: ");
        foreach (var element in courses)
        {
            System.Console.Write($"{element} ");
        }
        System.Console.WriteLine();
    }
    public double GetAverageGrade()
    {
        return grades.Sum()/grades.Count();
    }
    public override string ToString()
    {
        return $"Student: {_name} ({_address})";
    }
}