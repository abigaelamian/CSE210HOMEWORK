using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Learning C# Basics", "CodeWithAbigail", 540);
        Video video2 = new Video("Top 10 Coding Tips", "DevMaster", 720);
        Video video3 = new Video("Understanding OOP in C#", "TechGuide", 630);

        video1.AddComment(new Comment("John", "This was super helpful!"));
        video1.AddComment(new Comment("Mary", "Great explanation, thank you."));
        video1.AddComment(new Comment("Alex", "I finally understand classes now."));

        video2.AddComment(new Comment("Lisa", "Tip #3 really helped me."));
        video2.AddComment(new Comment("Brian", "Nice and clear video."));
        video2.AddComment(new Comment("Sophia", "Subscribing for more!"));

        video3.AddComment(new Comment("Kevin", "OOP makes more sense now."));
        video3.AddComment(new Comment("Nina", "Very well explained."));
        video3.AddComment(new Comment("Samuel", "Thanks for breaking it down."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.AuthorName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}