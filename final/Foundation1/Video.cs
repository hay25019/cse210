using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}, by {_author}. {_length} minutes long. This video has {GetNumOfComments()} comments.");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    public int GetNumOfComments()
    {
        return _comments.Count();
    }
}