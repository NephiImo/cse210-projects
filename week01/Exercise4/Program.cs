using System;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)   
            {
                numbers.Add(number);
            } 
        }
            int totalNumbers = numbers.Sum();
            float averageNumbers = (float)numbers.Average();
            int maxNumbers = numbers.Max();

            Console.WriteLine($"The sum is: {totalNumbers}");
            Console.WriteLine($"The average is: {averageNumbers}");
            Console.WriteLine($"The largest number is: {maxNumbers}");
        }   
    
}