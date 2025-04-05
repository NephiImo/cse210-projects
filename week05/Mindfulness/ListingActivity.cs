public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _availablePrompts;


    public ListingActivity(string name, string description, string userName) : base(name, description, userName)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "What are some things you are grateful for today?"
        };
        _availablePrompts = new List<string>(_prompts);
        Shuffle(_availablePrompts);
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nList the folowing:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {   
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
            Shuffle(_availablePrompts);
        }
        Console.WriteLine($"\n{_availablePrompts[0]}");
        _availablePrompts.RemoveAt(0);
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                list.Add(item);
            }
        }
        return list;
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