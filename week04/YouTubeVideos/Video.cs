public class Video
{
    //Tracks title, author, length(in seconds)//
    //Responsible for storing a list of comments for each video//

    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();


    //Constructor//
    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    //Method to get amount of comments
    public int GetAmountOfComments()
    {
        return _comments.Count;
    }
    //Method to get the title of the video
    public string GetTitle()
    {
        return _title;
    }
    //Method to get the author of the video
    public string GetAuthor()
    {
        return _author;
    }
    //Method to get the length of the video
    public float GetLength()
    {
        return _length;
    }
    //Method to add a comment to the Video object
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }    
    //Method to iterate through the comments and display them
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayText());
        }
    }
    
}


