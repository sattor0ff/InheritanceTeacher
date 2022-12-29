namespace MainApp.Services;

public class Teacher : Person
{
    private int _numCourses = 0;
    private List<string> courses;

    public Teacher(string name, string address) : base(name, address)
    {
        _name = name;
        _address = address;

        courses = new List<string>();
    }
    public bool AddCourse(string course)
    {
        var exists = courses.Exists(element => element == course);
        if(exists == true)
        {
            System.Console.Write("Course added: ");
            return false; 
        }
        else
        {
            courses.Add(course);
            System.Console.Write("Course added: ");
            return true;
        }
        
    }
    public void PrintCourse()
    {
        System.Console.Write("Courses: ");
        foreach (var element in courses)
        {
            System.Console.Write($"{element} ");
        }
        System.Console.WriteLine();
    }
    public bool RemoveCourse(string course)
    {
        var foundCourse = courses.Find(element => element == course);
        if(foundCourse == null)
        {
            System.Console.Write("Course removed: ");
            return false;
        }
        else
        {
            courses.Remove(foundCourse);
            System.Console.Write("Course removed: ");
            return true;
        }
    }
    public override string ToString()
    {
        return $"Teacher: {_name} ({_address})";
    }

}