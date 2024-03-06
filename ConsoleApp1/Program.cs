
using ConsoleApp1;
using ConsoleTables;
using System.Data;

Console.WriteLine( " " + "Enter your name");
var name = Console.ReadLine();
Console.WriteLine("Enter number of courses");
var num_course = int.Parse(Console.ReadLine());
List<Courses> courses = new List<Courses>();
for (int i = 0; i < num_course; i++)

{
      Console.WriteLine("Enter course name");
        var courseName = Console.ReadLine();
      Console.WriteLine("Enter course code e.g 101");
      var courseCode = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter course unit");
    var courseUnit = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Score");
      var Score = double.Parse(Console.ReadLine());
    courses.Add(new Courses(courseName,courseCode,courseUnit,Score));
}

var newTable = new ConsoleTable("Course Name", "Course code", "Course Unit", "Score");

foreach (var course in courses)
{
    newTable.AddRow(course.courseName,course.courseCode,course.courseUnit,course.courseScore);
}
newTable.Write();
var gpa = Calculator.calculator(courses);

Console.WriteLine("Your CGPA is " +  gpa);





