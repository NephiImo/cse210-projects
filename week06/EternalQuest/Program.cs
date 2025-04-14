using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

// --------CREATIVITY SHOWN---------
// I added a new class called AcievementManager that tracks the player's achievements.
// This class has a method called CheckAchievements that checks if the player has reached certain milestones in their score or goals.
// If they have, it prints a message to the console indicating that they have unlocked an achievement.
