using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Assignment class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        // Call the GetSummary method and print the result
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        // Create an instance of the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("James Churchill", "Fraction", "Section 7.3", "Problems 8-19");
        
        // Call the GetSummary method and print the result
        string mathSummary = mathAssignment.GetSummary();
        
        Console.WriteLine(mathSummary);

        // Call the GetHomeworkList method and print the result
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeworkList);

        // Create an instance of the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Samantha Adams", "European History", "The Causes of World War II");

        // Call the GetSummary method and print the result
        string writingSummary = writingAssignment.GetSummary();
        Console.WriteLine(writingSummary);

        // Call the GetWritingInformation method and print the result
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingInfo);
    }
}