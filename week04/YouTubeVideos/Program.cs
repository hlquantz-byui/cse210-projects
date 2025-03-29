using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        videos.Add(new Video());
        videos[0]._title = "Python Programming Basics";
        videos[0]._length = 600;
        videos[0]._author = "John Doe";
        videos[0]._comments.Add(new Comment());
        videos[0]._comments[0]._username = "Alice";
        videos[0]._comments[0]._comment = "Great introduction! I learned a lot.";
        videos[0]._comments.Add(new Comment());
        videos[0]._comments[1]._username = "Bob";
        videos[0]._comments[1]._comment = "Can you explain the functions in more detail?";
        videos[0]._comments.Add(new Comment());
        videos[0]._comments[2]._username = "Charlie";
        videos[0]._comments[2]._comment = "I love the examples you used!";

        videos.Add(new Video());
        videos[1]._title = "Advanced JavaScript Techniques";
        videos[1]._length = 900;
        videos[1]._author = "Jane Smith";
        videos[1]._comments.Add(new Comment());
        videos[1]._comments[0]._username = "David";
        videos[1]._comments[0]._comment = "This is exactly what I needed for my project!";
        videos[1]._comments.Add(new Comment());
        videos[1]._comments[1]._username = "Eva";
        videos[1]._comments[1]._comment = "The explanations were bery clear, thank you!";
        videos[1]._comments.Add(new Comment());
        videos[1]._comments[2]._username = "Frank";
        videos[1]._comments[2]._comment = "Could you do a follow-up on async programming";

        videos.Add(new Video());
        videos[2]._title = "Understanding Machine Learning";
        videos[2]._length = 1200;
        videos[2]._author = "Sarah Lee";
        videos[2]._comments.Add(new Comment());
        videos[2]._comments[0]._username = "Grace";
        videos[2]._comments[0]._comment = "Fascinating topic! I can't wait to learn more.";
        videos[2]._comments.Add(new Comment());
        videos[2]._comments[1]._username = "Henry";
        videos[2]._comments[1]._comment = "What resources do you recommend for beginners?";
        videos[2]._comments.Add(new Comment());
        videos[2]._comments[2]._username = "Ivy";
        videos[2]._comments[2]._comment = "The visuals really helped me understand the concepts.";

        videos.Add(new Video());
        videos[3]._title = "Web Development with React";
        videos[3]._length = 1500;
        videos[3]._author = "Mike Brown";
        videos[3]._comments.Add(new Comment());
        videos[3]._comments[0]._username = "Jack";
        videos[3]._comments[0]._comment = "Awesome tutorial! I'm excited to start building.";
        videos[3]._comments.Add(new Comment());
        videos[3]._comments[1]._username = "Lily";
        videos[3]._comments[1]._comment = "Can you cover state management in the next video?";
        videos[3]._comments.Add(new Comment());
        videos[3]._comments[2]._username = "Tom";
        videos[3]._comments[2]._comment = "I appreciate the step-by-step approach!";

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._username}: {comment._comment}");
            }
            Console.WriteLine("\n");
        }
    }
}