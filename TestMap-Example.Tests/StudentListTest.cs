/*
 * consulthunter
 * 2024-11-07
 * StudentListTest.cs
 */
using System.IO;
using JetBrains.Annotations;
using Xunit;

namespace TestMap_Example.Tests;

[TestSubject(typeof(StudentList))]
public class StudentListTest
{
    // Student string
    private const string Input = "John\n bob@email.com\n Freshman\n Computer Science\n 18\n 12345\n";

    /// <summary>
    /// Sets up the TextReader for the test.
    /// </summary>
    /// <param name="input">string for the TextReader, in this case a student string</param>
    /// <returns>TextReader</returns>
    private TextReader GetTextReader(string input)
    {
        return new StringReader(input);
    }

    /// <summary>
    /// Sets up the TextWriter for the test. 
    /// </summary>
    /// <returns>TextWriter</returns>
    private TextWriter GetTextWriter()
    {
        return new StringWriter();
    }
    
    /// <summary>
    /// Creates a new student list.
    /// </summary>
    /// <returns>StudentList</returns>
    private StudentList GetStudentList()
    {
        return new StudentList();
    }
    
    /// <summary>
    /// Creates a TextReader, TextWriter, adds the student to the list
    /// Checks that the student is added.
    /// </summary>
    [Fact]
    public void TestAddStudent()
    {
        // Arrange
        const string expected = "The student has been added to the list.";
        var reader = GetTextReader(Input);
        var writer = GetTextWriter();
        var studentList = GetStudentList();

        // Act
        studentList.AddStudent(reader, writer);
        var actual = writer.ToString() ?? string.Empty;

        // Assert
        Assert.Contains(expected, actual);
    }

    /// <summary>
    /// Creates a TextReader, TextWriter, adds the student to the list twice
    /// Checks that the student is already present in the list.
    /// </summary>
    [Fact]
    public void TestAddStudentAlreadyPresent()
    {
        // Arrange
        const string expected = "The student is already present in the list.";
        var readerInitial = GetTextReader(Input);
        var writerInitial = GetTextWriter();
        var readerExtra = GetTextReader(Input);
        var writerExtra = GetTextWriter();
        var studentList = GetStudentList();

        // Act
        studentList.AddStudent(readerInitial, writerInitial);
        studentList.AddStudent(readerExtra, writerExtra);
        var actual = writerExtra.ToString() ?? string.Empty;

        // Assert
        Assert.Contains(expected, actual);
    }

    /// <summary>
    /// Creates a TextReader, TextWriter, adds the student to the list, removes the student
    /// Checks that the student is removed from the list.
    /// </summary>
    [Fact]
    public void TestRemoveStudent()
    {
        // Arrange
        const string expected = "The student has been removed from the list.";
        var readerInitial = GetTextReader(Input);
        var writerInitial = GetTextWriter();
        var readerExtra = GetTextReader(Input);
        var writerExtra = GetTextWriter();
        var studentList = GetStudentList();

        // Act
        studentList.AddStudent(readerInitial, writerInitial);
        studentList.RemoveStudent(readerExtra, writerExtra);
        var actual = writerExtra.ToString() ?? string.Empty;

        // Assert
        Assert.Contains(expected, actual);
    }
}