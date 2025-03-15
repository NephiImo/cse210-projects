using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    
                    Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully.");
                    break;
                
                case "2":
                    theJournal.DisplayAll();
                    break;
                
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;
                
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;
                
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}


/*
    === EXCEEDING CORE REQUIREMENTS ===

    This program exceeds the core requirements by implementing JSON-based file storage 
    instead of a simple text format. This improves readability, structure, and scalability.
*/
