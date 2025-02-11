using System;

class Program
{
    static void Main(string[] args)
    {
        //List of videos
        List<Video> _videos = new List<Video>();
        Video video1 = new Video("Today's Motivational Speech", "WeAreAllMotivationalSpeakers", 180);
        Video video2 = new Video("The Power of Prayer", "Jane Doe", 212);
        Video video3 = new Video("Baby and You", "MamaBear", 500);
        Video video4 = new Video("All things in moderation", "justmyopin1on", 120);

        //Comments
        Comment comment1 = new Comment("John Doe", "I love this video! Definitely going to sub!");
        Comment comment2 = new Comment("Doe John", "I want to see more of these. Please keep making them!");
        Comment comment3 = new Comment("MrBallen", "I'm going to share these videos on my page! I love them!");
        Comment comment4 = new Comment("SSZero09", "Liked and subscribed. Will keep an eye out for more!");
        Comment comment5 = new Comment("Raiden", "Hello! Please respond to me!");
        Comment comment6 = new Comment("Opinionated", "I don't think this is right.");
        Comment comment7 = new Comment("NewMom", "This was very insightful. THANK YOU!!!");
        //Author comments
        Comment commentVideo4 = new Comment("justmyopin1on", "I appreciate all the support!");
        Comment commentVideo3 = new Comment("MamaBear", "Please reach out to me if you want to share anything of your own! I love to hear about each of your babies!");
        Comment commentVideo2 = new Comment("Jane Doe", "Never underestimate the power of prayer. I testify it works! Try it yourself!!");
        Comment commentVideo1 = new Comment("WeAreAllMotivationalSpeakers", "Keep your head up fellas! We need to be strong for our loved ones.");

        //Adding comments to videos
        //Video 1 //4 comments
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(commentVideo1);
        _videos.Add(video1);
        //Video 2 //4 comments
        video2.AddComment(comment2);
        video2.AddComment(comment4);
        video1.AddComment(comment6);
        video2.AddComment(commentVideo2);
        _videos.Add(video2);
        //Video 3 //3 comments
        video3.AddComment(comment5);
        video3.AddComment(comment7);
        video3.AddComment(commentVideo3);
        _videos.Add(video3);
        //Video 4 //5 comments
        video4.AddComment(comment1);
        video4.AddComment(comment3);
        video4.AddComment(comment5);
        video3.AddComment(comment6);
        video4.AddComment(commentVideo4);
        _videos.Add(video4);

        //Displaying each videos attributes(title, author, length in seconds, number of comments) and comments(name and text)
        foreach (Video video in _videos)
        {
            Console.WriteLine(" -- " + $"Title: {video.GetTitle()}" + " -- " + $"Author: {video.GetAuthor()}" + " -- " + $"Length(in seconds): {video.GetLength()}" + " -- " + $"Number of Comments: {video.GetAmountOfComments()}" + " -- ");
            video.DisplayComments();
        }


    }
}