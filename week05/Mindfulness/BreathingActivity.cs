public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, string userName) : base(name, description, userName)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int interval = 6;

        while (duration > 0)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(3);
            Console.Write("\nBreathe out... ");
            ShowCountdown(3);
            duration -= interval;
        }

        DisplayEndingMessage();
    }
}