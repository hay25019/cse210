using System.ComponentModel.DataAnnotations;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}, by {_author}. {_length} minutes long. This video has {GetNumOfComments()} comments.");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
    public int GetNumOfComments()
    {
        return _comments.Count();
    }
}