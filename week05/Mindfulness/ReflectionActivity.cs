public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _availablePrompts;
    private List<string> _availableQuestions;


    public ReflectionActivity(string name, string description, string userName) : base(name, description, userName)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite memory of this experience?",
            "What did you learn from this experience?",
            "How can you apply what you learned to your life today?"
        };

        _availablePrompts = new List<string>(_prompts);
        _availableQuestions = new List<string>(_questions);
        Shuffle(_availablePrompts);
        Shuffle(_availableQuestions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
            Shuffle(_availablePrompts);
        }
        string prompt = _availablePrompts[0];
        _availablePrompts.RemoveAt(0);
        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
            Shuffle(_availableQuestions);
        }
        string question = _availableQuestions[0];
        _availableQuestions.RemoveAt(0);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"> {GetRandomPrompt()}\n");
        Console.Write("Press enter to continue...");
        Console.ReadLine();
        Console.WriteLine("Ponder on the following questions.");
        ShowSpinner(3);
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(5);
        Console.WriteLine();
    }

    private void Shuffle<T>(List<T> list)
    {
        Random random = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
}