using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Cooking with Grandma", "TastyKitchen", 420);
        video1.AddComment(new Comment("Alice", "Love this recipe!"));
        video1.AddComment(new Comment("John", "Reminds me of my childhood."));
        video1.AddComment(new Comment("Maya", "Grandma is so cute!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Gadget Review: XPhone Z", "TechGuru", 315);
        video2.AddComment(new Comment("Sam", "Very informative."));
        video2.AddComment(new Comment("Elena", "Can't wait to try this."));
        video2.AddComment(new Comment("Paul", "Clear and concise!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("10 Minute Morning Yoga", "HealthyVibes", 600);
        video3.AddComment(new Comment("Chris", "Perfect way to start the day."));
        video3.AddComment(new Comment("Dina", "My back feels amazing now!"));
        video3.AddComment(new Comment("Tolu", "Thank you for this!"));
        videos.Add(video3);

        // Display info
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommmentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
