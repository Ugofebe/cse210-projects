public class Comment
{
    // Properties
    public string CommenterName { get; private set; }
    public string Text { get; private set; }

    // My Constructor
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}