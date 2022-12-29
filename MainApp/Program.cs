using MainApp.Services;

var student = new Student("ArdasheR", "Softclub");
System.Console.WriteLine(student.ToString());
student.AddCourseGrade("c++", 10);
student.AddCourseGrade("c#", 5);

student.PrintGrades();
student.PrintCourse();
System.Console.WriteLine();

var teacher = new Teacher("Alijon", "Dushanbe");
System.Console.WriteLine(teacher.ToString());
System.Console.WriteLine(teacher.AddCourse("c#")); 
System.Console.WriteLine(teacher.AddCourse("c++")); 

System.Console.WriteLine(teacher.AddCourse("c#"));

teacher.PrintCourse();

System.Console.WriteLine(teacher.RemoveCourse("c++"));
teacher.PrintCourse();