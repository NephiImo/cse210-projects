using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = " ";
        string letterGrade = " ";

        int remainder = grade % 10;

        if (remainder >= 7)
        {
            letterGrade = "+";
        }
        else if (remainder < 3)
        {
            letterGrade = "-";
        }
        else
        {
            letterGrade = " ";
        }

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}{letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time!");
        }        
    }
}