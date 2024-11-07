/*
 * consulthunter
 * 2024-11-07
 * StudentTest.cs
 */
using NUnit.Framework;


namespace TestMap_Example.Tests;

[TestFixture]
[TestOf(typeof(Student))]
public class StudentTest
{
    private readonly string Name = "John";
    private readonly string Email = "bob@email.com";
    private readonly string GradeLevel = "Freshman";
    private readonly string Major = "Computer Science";
    private readonly int Age = 18;
    private readonly int Id = 12345;

    /// <summary>
    /// Sets up the Student with options
    /// </summary>
    /// <returns>Student</returns>
    private Student CreateStudentWithOptions()
    {
        return new Student(Name, Email, GradeLevel, Major, Age, Id);
    }
    
    /// <summary>
    /// Sets up Student with defaulted options
    /// </summary>
    /// <returns>Student</returns>
    private Student CreateStudent()
    {
        return new Student();
    }

    /// <summary>
    /// Tests the Student with specified options.
    /// </summary>
    [Test]
    public void TestStudentConstructorWithOptions()
    {
        // Arrange
        var student = CreateStudentWithOptions();

        // Act
        var actualName = student.Name;
        var actualEmail = student.Email;
        var actualGradeLevel = student.GradeLevel;
        var actualMajor = student.Major;
        var actualAge = student.Age;
        var actualId = student.Id;

        // Assert
        Assert.That(actualName.Equals(Name));
        Assert.That(actualEmail.Equals(Email));
        Assert.That(actualGradeLevel.Equals(GradeLevel));
        Assert.That(actualMajor.Equals(Major));
        Assert.That(actualAge.Equals(Age));
        Assert.That(actualId.Equals(Id));
    }

    /// <summary>
    /// Tests the student with defaulted options.
    /// </summary>
    [Test]
    public void TestStudentConstructor()
    {
        // Arrange
        const string expectString = "";
        const int expectInt = 0;
        var student = CreateStudent();

        // Act
        var actualName = student.Name;
        var actualEmail = student.Email;
        var actualGradeLevel = student.GradeLevel;
        var actualMajor = student.Major;
        var actualAge = student.Age;
        var actualId = student.Id;

        // Assert
        Assert.That(actualName.Equals(expectString));
        Assert.That(actualEmail.Equals(expectString));
        Assert.That(actualGradeLevel.Equals(expectString));
        Assert.That(actualMajor.Equals(expectString));
        Assert.That(actualAge.Equals(expectInt));
        Assert.That(actualId.Equals(expectInt));
    }
}