/*
 * consulthunter
 * 2024-11-07
 * StudentTest.cs
 */
namespace TestMap_Example;

public class StudentList
{
    // Variables
    private List<Student> Students { get; set; }

    // Methods
    /// <summary>
    /// Takes in student information from the Console
    /// </summary>
    /// <param name="reader">TextReader, set to Console.In</param>
    /// <param name="writer">TextWriter, set to Console.Out</param>
    /// <returns>Student from the information provided.</returns>
    private Student GetStudentInfo(TextReader reader, TextWriter writer)
    {
        writer.WriteLine("Enter the student's name: ");
        var name = (reader.ReadLine() ?? string.Empty).Trim();

        writer.WriteLine("Enter the student's email: ");
        var email = (reader.ReadLine() ?? string.Empty).Trim();

        writer.WriteLine("Enter the student's grade level: ");
        var gradeLevel = (reader.ReadLine() ?? string.Empty).Trim();

        writer.WriteLine("Enter the student's major: ");
        var major = (reader.ReadLine() ?? string.Empty).Trim();

        writer.WriteLine("Enter the student's age: ");
        var age = 0;
        try
        {
            age = int.Parse(reader.ReadLine() ?? "0");
        }
        catch (FormatException)
        {
            writer.WriteLine("Error parsing student's age.");
        }

        writer.WriteLine("Enter the student's ID: ");
        var id = 0;
        try
        {
            id = int.Parse(reader.ReadLine() ?? "0");
        }
        catch (FormatException)
        {
            writer.WriteLine("Error parsing student's ID");
        }

        return new Student(name, email, gradeLevel, major, age, id);
    }

    /// <summary>
    /// Adds a student to the list.
    /// </summary>
    /// <param name="reader">TextReader, set to Console.In</param>
    /// <param name="writer">TextWriter, set to Console.Out</param>
    public void AddStudent(TextReader reader, TextWriter writer)
    {
        var student = GetStudentInfo(reader, writer);

        foreach (var present in Students)
            if (present.Id == student.Id)
            {
                writer.WriteLine("The student is already present in the list.");
                return;
            }

        Students.Add(student);
        writer.WriteLine("The student has been added to the list.");
    }

    /// <summary>
    /// Removes a student from the list.
    /// </summary>
    /// <param name="reader">TextReader, set to Console.In</param>
    /// <param name="writer">TextWriter, set to Console.Out</param>
    public void RemoveStudent(TextReader reader, TextWriter writer)
    {
        var student = GetStudentInfo(reader, writer);

        foreach (var present in Students)
            if (present.Id == student.Id)
            {
                Students.Remove(student);
                writer.WriteLine("The student has been removed from the list.");
                return;
            }

        writer.WriteLine("The student is not in the list.");
    }

    /// <summary>
    /// Prints students in the list.
    /// </summary>
    public void Print()
    {
        foreach (var student in Students)
            Console.WriteLine($"Name: {student.Name}, Email: {student.Email}, " +
                              $"Grade Level: {student.GradeLevel}, Major: {student.Major}, " +
                              $"Age: {student.Age}, ID: {student.Id}");
    }
    // Constructor
    public StudentList()
    {
        Students = new List<Student>();
    }
}