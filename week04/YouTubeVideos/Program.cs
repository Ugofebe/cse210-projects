using System;

class Program
{
    static void Main(string[] args)
    {
        // Created a list to hold videos
        List<Video> videos = new List<Video>();

        // Created and added my first video
        Video video1 = new Video("How to Make Pancakes", "Chef John", 300);
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "I tried this and it was amazing!"));
        video1.AddComment(new Comment("Charlie", "Can I substitute milk with almond milk?"));
        videos.Add(video1);

        // Created and added the second video
        Video video2 = new Video("C# Programming Basics", "CodeMaster", 450);
        video2.AddComment(new Comment("Dave", "Very helpful tutorial!"));
        video2.AddComment(new Comment("Eve", "I'm learning so much from your videos"));
        video2.AddComment(new Comment("Frank", "Could you make a video on classes next?"));
        video2.AddComment(new Comment("Grace", "Perfect explanation of variables"));
        videos.Add(video2);

        // Created and added the third video
        Video video3 = new Video("Morning Yoga Routine", "YogaWithSarah", 600);
        video3.AddComment(new Comment("Heidi", "This is my daily routine now!"));
        video3.AddComment(new Comment("Ivan", "Helped with my back pain"));
        video3.AddComment(new Comment("Judy", "The breathing exercises are life-changing"));
        videos.Add(video3);

        // Created and added a fourth video
        Video video4 = new Video("Travel Vlog: Japan 2023", "Wanderlust", 900);
        video4.AddComment(new Comment("Kevin", "Beautiful shots!"));
        video4.AddComment(new Comment("Linda", "I'm planning my trip thanks to this"));
        video4.AddComment(new Comment("Mike", "What camera do you use?"));
        video4.AddComment(new Comment("Nancy", "The food looks incredible"));
        videos.Add(video4);

        // Displays information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}