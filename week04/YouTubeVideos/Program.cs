using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Cooking Lassagna", "Irving Super", 610);
        Video video2 = new Video("Funny Videos", "Funny Channel", 300);
        Video video3 = new Video("How to dance?", "Mariana Hernandez", 700);

        
        video1.Comments.Add(new Comment("User1", "This is an original recipe"));
        video1.Comments.Add(new Comment("User2", "I don't like it that way"));
        video1.Comments.Add(new Comment("User3", "I ussually put more sauce"));
        
        video2.Comments.Add(new Comment("User4", "That was funny!!"));
        video2.Comments.Add(new Comment("User5", "The cat and dog were hilarious"));
        
        video3.Comments.Add(new Comment("User6", "She is a good dancer"));
        video3.Comments.Add(new Comment("User7", "These tips are awesome, I will apply them later tonight!"));
        video3.Comments.Add(new Comment("User8", "Can you teach salsa in your next video?"));

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}\n");

            
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}