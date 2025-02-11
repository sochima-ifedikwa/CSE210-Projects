using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Fundamentals of C#", "Sochima Ifedikwa", 900);
        Video video2 = new Video("Understanding Encapsulation", "Jane Doe", 3600);
        Video video3 = new Video("Understanding Inheritance", "Jane Doe", 3000);
        Video video4 = new Video("Understanding Polymorphism", "Jane Doe", 5000);


        video1.AddComment(new Comment("John Smith", "This is a great video"));
        video1.AddComment(new Comment("Miracle Adeoye", "My first programming language video to make sense"));
        video1.AddComment(new Comment("Victor David", "I am so ready for this course now"));
        video1.AddComment(new Comment("Ajani Isaac", "The best video I have ever seen"));

        video2.AddComment(new Comment("Mary Jane", "Making sense of encapsulation"));
        video2.AddComment(new Comment("Peter Parker", "I feel like I am a programmer now"));
        video2.AddComment(new Comment("Bruce Wayne", "Now I can put my classes in a capsule"));
        video2.AddComment(new Comment("Jennifer Hudson", "I shared this with my friend and she loved it"));

        video3.AddComment(new Comment("Iron Man", "You are a genius"));
        video3.AddComment(new Comment("Taylor Swift", "I have inherited the knowledge of inheritance"));
        video3.AddComment(new Comment("Ifeanyi Okoro", "What wmould I have done without this video?"));
        video3.AddComment(new Comment("Emmanuel Okeke", "Every programmer should watch this video"));

        video4.AddComment(new Comment("Sarah Jones", "Heard of the concept before but I understand it better now"));
        video4.AddComment(new Comment("Cena Johnson", "Best video to understand Polymorphism"));
        video4.AddComment(new Comment("Brock Lesnar", "Even a baby can understand this video very well"));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach(var video in videos)
        {
            Console.WriteLine(video.VideoDetail());
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComment()}");

            foreach (var comment in video._listOfComments) 
            {
                Console.WriteLine("Comments in the video are :");
                Console.WriteLine($"Comment by {comment.GetCommenter} : {comment.GetTextComment}");
            }
        }

    }
}