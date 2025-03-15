using System;

public class Entry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Date: {Date}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Prompt: {PromptText}");
        Console.ResetColor();

        Console.WriteLine($"Response: {EntryText}\n");
    }
}