using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! Welcome to my YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("Learn C# in 10 Minutes", "Tumwesige Nelson", 600);
        video1.AddComment(new Comment("Kenny", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Josua", "Great explanation brother, I love it."));
        video1.AddComment(new Comment("Kahunde", "Can you do a part 2 for us please?"));
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("Top 10 Coding Tips", "Nelson", 420);
        video2.AddComment(new Comment("David", "Love tip #2!"));
        video2.AddComment(new Comment("Emmanuel", "This is gold."));
        video2.AddComment(new Comment("Frank", "Shared with my team and friends"));
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("How to push your work to your Github repo in Vs Code", "Tumwesige Nelson", 900);
        video3.AddComment(new Comment("Grace", "Yummy!"));
        video3.AddComment(new Comment("Henry", "Tried it but still having an error of (Having no access to the repo)"));
        video3.AddComment(new Comment("Newton", "Easy to follow. love it."));
        videos.Add(video3);

        // Create Video 4
        Video video4 = new Video("installing and setting Vs Code for coding", "Nelson Mikel", 300);
        video4.AddComment(new Comment("Jack", "All great, it worked for me without an error thanks:"));
        video4.AddComment(new Comment("Deogratious", "Its rilly great for windows, make one for MAC users."));
        video4.AddComment(new Comment("Liam", "You gat my hearts, thanks brother"));
        videos.Add(video4);

        // Display all video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
