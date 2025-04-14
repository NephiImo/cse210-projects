public class AchievementManager
{
    private HashSet<string> _earnedAchievements = new HashSet<string>();

    public void CheckAchievements(int score, List<Goal> goals)
    {
        if (score >= 100 && _earnedAchievements.Add("Century Club"))
        {
            Console.WriteLine("🏆 Achievement Unlocked: Century Club (100+ points)!");
        }

        if (goals.Count >= 5 && _earnedAchievements.Add("Goal Getter"))
        {
            Console.WriteLine("🏆 Achievement Unlocked: Goal Getter (5+ goals created)!");
        }

        foreach (Goal goal in goals)
        {
            if (goal is ChecklistGoal checklist && checklist.IsComplete() && _earnedAchievements.Add("Checklist Champion"))
            {
                Console.WriteLine("🏆 Achievement Unlocked: Checklist Champion (Completed a Checklist Goal)!");
                break;
            }
        }
    }
}