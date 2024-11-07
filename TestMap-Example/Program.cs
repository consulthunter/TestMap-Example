/*
 * consulthunter
 * 2024-11-07
 * Program.cs
 */
namespace TestMap_Example;

public class Program
{
    /// <summary>
    /// Main
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        var reader = Console.In;
        var writer = Console.Out;
        Start(reader, writer);
    }

    /// <summary>
    /// Asks user to add, remove, or view the list of students.
    /// </summary>
    /// <param name="reader">TextReader, set to Console.In</param>
    /// <param name="writer">TextWriter, set to Console.Out</param>
    public static void Start(TextReader reader, TextWriter writer)
    {
        writer.WriteLine("Hello, welcome to the student database!\n" +
                         "This is a simple program that allows you to add and remove students from a list.\n" +
                         "You can also view the list of students.");
        var choice = "";
        var studentList = new StudentList();
        while (choice != "4")
        {
            PrintMenu();
            choice = reader.ReadLine() ?? string.Empty;
            switch (choice)
            {
                case "1":
                    studentList.AddStudent(reader, writer);
                    break;
                case "2":
                    studentList.RemoveStudent(reader, writer);
                    break;
                case "3":
                    studentList.Print();
                    break;
                case "4":
                    writer.WriteLine("Goodbye!");
                    break;
                default:
                    writer.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    /// <summary>
    /// Prints a CLI menu.
    /// </summary>
    private static void PrintMenu()
    {
        Console.WriteLine("1. Add a student\n" +
                          "2. Remove a student\n" +
                          "3. View the list of students\n" +
                          "4. Exit\n" +
                          "Enter your choice: ");
    }
}