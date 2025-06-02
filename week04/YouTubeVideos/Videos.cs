using System.Collections.Generic;

public class Video
{
    // Properties
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; } // in seconds
    public List<Comment> Comments { get; private set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}