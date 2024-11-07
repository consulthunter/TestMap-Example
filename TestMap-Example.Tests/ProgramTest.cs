/*
 * consulthunter
 * 2024-11-07
 * ProgramTest.cs
 */
using System.IO;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMap_Example.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class ProgramTest
{
    /// <summary>
    /// Ensures proper exit upon correct choice.
    /// </summary>
    [TestMethod]
    public void TestMainExit()
    {
        // Arrange
        const string input = "4";
        const string expected = "Goodbye!";
        TextReader reader = new StringReader(input);
        TextWriter writer = new StringWriter();

        // Act
        Program.Start(reader, writer);
        var actual = writer.ToString() ?? string.Empty;

        // Assert
        Assert.IsTrue(actual.Contains(expected));
    }
}