public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    protected string _userName;

    public Activity(string name, string description, string userName)
    {
        _name = name;
        _description = description;
        _userName = userName;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome, {_userName} to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine($"Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done, {_userName}!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {   
        string[] spinner = {"|", "/", "-", "\\"};
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int GetDuration()
    {
        return _duration;
    }
}
