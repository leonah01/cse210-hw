using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // a list of videos
        List<Video> videos = new List<Video>();

        // 3 videos and added comments to them
        Video v1 = new Video("Video 1", "Sam Alexandra", 320);
        v1.AddComment("Brenda", "Ohh wow I enjoyed!");
        v1.AddComment("Praise", "I agree, this was really great.");

        Video v2 = new Video("Video 2", "Levis Miles", 200);
        v2.AddComment("Wonder", "interesting to watch!");

        Video v3 = new Video("Video 3", "Hannah Millers", 110);
        v3.AddComment("Moses", "This was educational.");

        // Add the videos to the list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Display information for each video in the list
        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.Title);
            Console.WriteLine("Author: " + v.Author);
            Console.WriteLine("Length: " + v.Length + " seconds");
            Console.WriteLine("Number of comments: " + v.GetNumberOfComments());

            // Display all the comments for the video
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine("- " + c.CommenterName + ": " + c.Text);
            }

            Console.WriteLine(); // Add a blank line for spacing
        }
    }
}