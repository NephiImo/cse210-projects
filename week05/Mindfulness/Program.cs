
///                             ----CREATIVITY AND EXCEEDING REQUIREMENTS----
/// - The program asks the user for their name and uses it throughout the program.
/// - The program shuffles the prompts and questions for each activity to ensure a different experience each time.  

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Mindfulness App, {userName}!");
            Console.WriteLine("1. Start Breathing Exercise");
            Console.WriteLine("2. Start Reflecting Exercise");
            Console.WriteLine("3. Start Listing Exercise");
            Console.WriteLine("4. Quit");
            Console.Write("Please select an option (1-4): ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", userName).Run();
                    break;
                case "2":
                    new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userName).Run();
                    break;
                case "3":
                    new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userName).Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}

