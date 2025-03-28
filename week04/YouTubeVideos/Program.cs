using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Beta Squad are back!", "Beta Squad", 300);
        Video video2 = new Video("The Sidemen are back!", "Sidemen", 1000);
        Video video3 = new Video("The Dream Team are back!", "Dream Team", 500);

        // Add comments to video1
        video1.AddComment ( new Comment("John", "This video is amazing!"));
        video1.AddComment ( new Comment("Nathan", "I love this video!"));
        video1.AddComment ( new Comment("Sarah", "This video is so funny!"));

        // Add comments to video2
        video2.AddComment(new Comment("Emma", "Ethan with the volleyyyy!"));
        video2.AddComment(new Comment("Tom", "Harry's got yams for legs"));
        video2.AddComment(new Comment("Lucy", "Simon's laugh is so contagious!"));

        // Add comments to video3
        video3.AddComment(new Comment("Oliver", "This is the most entertaining stuff since sliced bread!"));
        video3.AddComment(new Comment("Sophie", "I love the Dream Team!"));
        video3.AddComment(new Comment("James", "This video is so funny, I literally can't stop laughing!"));

        List<Video> videosList = new List<Video> { video1, video2, video3 };

        foreach (var video in videosList)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}